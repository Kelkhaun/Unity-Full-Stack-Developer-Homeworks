using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventories
{
    public sealed class Inventory : IEnumerable<Item>
    {
        public event Action<Item, Vector2Int> OnAdded;
        public event Action<Item, Vector2Int> OnRemoved;
        public event Action<Item, Vector2Int> OnMoved;
        public event Action OnCleared;

        public int Width => _width;
        public int Height => _height;
        public int Count => _count;

        private int _width;
        private int _height;
        private int _count;

        private readonly HashSet<Item> _items = new HashSet<Item>();
        private Item[,] _grid;

        public Inventory(in int width, in int height)
        {
            if (width < 0 ||
                height < 0 ||
                (width == 0 && height == 0))
                throw new ArgumentException();

            _width = width;

            _height = height;

            _grid = new Item[width, height];
            _count = 0;
        }

        public Inventory(
            in int width,
            in int height,
            params KeyValuePair<Item, Vector2Int>[] items
        ) : this(width, height)
        {
            if (items == null)
                throw new ArgumentNullException("items is null");

            for (int i = 0; i < items.Length; i++)
                AddItem(items[i].Key, items[i].Value);
        }

        public Inventory(
            in int width,
            in int height,
            params Item[] items
        ) : this(width, height)
        {
            if (items == null)
                throw new ArgumentNullException("items is null");

            for (int i = 0; i < items.Length; i++)
                AddItem(items[i]);
        }

        public Inventory(
            in int width,
            in int height,
            in IEnumerable<KeyValuePair<Item, Vector2Int>> items
        ) : this(width, height)
        {
            if (items == null)
                throw new ArgumentNullException("items is null");

            foreach (var item in items)
                AddItem(item.Key, item.Value);
        }

        public Inventory(
            in int width,
            in int height,
            in IEnumerable<Item> items
        ) : this(width, height)
        {
            if (items == null)
                throw new ArgumentNullException("items is null");

            foreach (var item in items)
                AddItem(item);
        }

        /// <summary>
        /// Checks for adding an item on a specified position
        /// </summary>
        public bool CanAddItem(in Item item, in Vector2Int position)
        {
            return CanAddItem(item, position.x, position.y);
        }

        public bool CanAddItem(in Item item, in int posX, in int posY)
        {
            if (item == null) return false;
            if (Contains(item)) return false;

            if (!IsFreeSpace(item.Size.x, item.Size.y, posX, posY)) return false;

            return true;
        }

        private bool IsFreeSpace(in int sizeX, in int sizeY, in int posX, in int posY)
        {
            if (sizeX <= 0 || sizeY <= 0)
                throw new ArgumentException();

            if (posX < 0 || posY < 0) return false;
            if (posX + sizeX > _width || posY + sizeY > _height) return false;

            for (int x = posX; x < posX + sizeX; x++)
            {
                for (int y = posY; y < posY + sizeY; y++)
                {
                    if (_grid[x, y] != null)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Adds an item on a specified position if not exists
        /// </summary>
        public bool AddItem(in Item item, in Vector2Int position)
        {
            return AddItem(item, position.x, position.y);
        }

        public bool AddItem(in Item item, in int posX, in int posY)
        {
            if (!CanAddItem(item, posX, posY))
                return false;

            for (int x = posX; x < posX + item.Size.x; x++)
            {
                for (int y = posY; y < posY + item.Size.y; y++)
                {
                    _grid[x, y] = item;
                }
            }

            _count++;
            _items.Add(item);
            OnAdded?.Invoke(item, new Vector2Int(posX, posY));
            return true;
        }

        /// <summary>
        /// Checks for adding an item on a free position
        /// </summary>
        public bool CanAddItem(in Item item)
        {
            if (item == null) return false;
            if (Contains(item)) return false;

            return FindFreePosition(item, out var position);
        }

        /// <summary>
        /// Adds an item on a free position
        /// </summary>
        public bool AddItem(in Item item)
        {
            if (item == null) return false;

            if (!FindFreePosition(item, out var position))
                return false;

            return AddItem(item, position);
        }

        /// <summary>
        /// Returns a free position for a specified item
        /// </summary>
        public bool FindFreePosition(in Item item, out Vector2Int freePosition)
        {
            return FindFreePosition(item.Size.x, item.Size.y, out freePosition);
        }

        public bool FindFreePosition(in Vector2Int size, out Vector2Int freePosition)
        {
            return FindFreePosition(size.x, size.y, out freePosition);
        }

        public bool FindFreePosition(in int sizeX, int sizeY, out Vector2Int freePosition)
        {
            freePosition = default;

            if (sizeX <= 0 || sizeY <= 0)
                throw new ArgumentException();

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (IsFreeSpace(sizeX, sizeY, x, y))
                    {
                        freePosition.x = x;
                        freePosition.y = y;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a specified item exists
        /// </summary>
        public bool Contains(in Item item)
        {
            for (int x = 0; x < _width; x++)
            for (int y = 0; y < _height; y++)
                if (_grid[x, y] != null)
                    if (_grid[x, y].Equals(item))
                        return true;

            return false;
        }

        /// <summary>
        /// Checks if a specified position is occupied
        /// </summary>
        public bool IsOccupied(in Vector2Int position)
        {
            return _grid[position.x, position.y] != null;
        }

        public bool IsOccupied(in int x, in int y)
        {
            return _grid[x, y] != null;
        }

        /// <summary>
        /// Checks if the a position is free
        /// </summary>
        public bool IsFree(in Vector2Int position)
        {
            return _grid[position.x, position.y] == null;
        }

        public bool IsFree(in int x, in int y)
        {
            return _grid[x, y] == null;
        }

        /// <summary>
        /// Removes a specified item if exists
        /// </summary>
        public bool RemoveItem(in Item item)
        {
            return RemoveItem(item, out Vector2Int position);
        }

        public bool RemoveItem(in Item item, out Vector2Int position)
        {
            position = default;
            if (item == null) return false;
            if (!Contains(item)) return false;

            bool isFinded = false;

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (_grid[x, y] != null)
                    {
                        if (_grid[x, y].Equals(item))
                        {
                            _grid[x, y] = null;

                            if (!isFinded)
                            {
                                position.x = x;
                                position.y = y;
                                isFinded = true;
                            }
                        }
                    }

                }
            }

            if (isFinded)
            {
                _count--;
                _items.Remove(item);
                OnRemoved?.Invoke(item, position);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns an item at specified position 
        /// </summary>
        public Item GetItem(in Vector2Int position)
        {
            return GetItem(position.x, position.y);
        }

        public Item GetItem(in int x, in int y)
        {
            if (x >= _width || y >= _height || x < 0 || y < 0)
                throw new IndexOutOfRangeException();

            if (_grid[x, y] == null)
                throw new NullReferenceException();

            return _grid[x, y];
        }

        public bool TryGetItem(in Vector2Int position, out Item item)
        {
            return TryGetItem(position.x, position.y, out item);
        }

        public bool TryGetItem(in int x, in int y, out Item item)
        {
            if (x >= _width || y >= _height || x < 0 || y < 0)
            {
                item = null;
                return false;
            }

            item = _grid[x, y];

            if (item == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Returns matrix positions of a specified item 
        /// </summary>
        public Vector2Int[] GetPositions(in Item item)
        {
            if (item == null)
                throw new NullReferenceException();

            if (!Contains(item))
                throw new KeyNotFoundException();

            return GetItemPositions(item);
        }

        public bool TryGetPositions(in Item item, out Vector2Int[] positions)
        {
            positions = default;

            if (item == null)
                return false;

            if (!Contains(item))
                return false;

            positions = GetItemPositions(item);
            return true;
        }

        private Vector2Int[] GetItemPositions(Item item)
        {
            Vector2Int[] position = new Vector2Int[item.Size.x * item.Size.y];
            int _currentIndex = 0;

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    if (_grid[x, y] != null)
                    {
                        if (_grid[x, y].Equals(item))
                        {
                            position[_currentIndex] = new Vector2Int(x, y);
                            _currentIndex++;
                        }
                    }
                }
            }

            return position;
        }

        /// <summary>
        /// Clears all inventory items
        /// </summary>
        public void Clear()
        {
            if (Count == 0)
                return;

            for (int x = 0; x < _width; x++)
            for (int y = 0; y < _height; y++)
                _grid[x, y] = null;

            _items.Clear();
            _count = 0;
            OnCleared?.Invoke();
        }

        /// <summary>
        /// Returns a count of items with a specified name
        /// </summary>
        public int GetItemCount(string name)
        {
            int count = 0;

            foreach (var item in _items)
                if (item.Name == name)
                    count++;

            return count;
        }

        /// <summary>
        /// Moves a specified item at target position if exists
        /// </summary>
        public bool MoveItem(in Item item, in Vector2Int position)
        {
            Vector2Int prevPosition = default;
            if (item == null)
                throw new ArgumentNullException();

            if (!Contains(item)) return false;

            bool isFinded = false;

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (_grid[x, y] != null)
                    {
                        if (_grid[x, y].Equals(item))
                        {
                            _grid[x, y] = null;

                            if (!isFinded)
                            {
                                prevPosition.x = x;
                                prevPosition.y = y;
                                isFinded = true;
                            }
                        }
                    }

                }
            }

            if (CanAddItem(item, position))
            {
                for (int x = position.x; x < position.x + item.Size.x; x++)
                {
                    for (int y = position.y; y < position.y + item.Size.y; y++)
                    {
                        _grid[x, y] = item;
                    }
                }

                OnMoved?.Invoke(item, position);
                return true;
            }
            else
            {
                for (int x = prevPosition.x; x < prevPosition.x + item.Size.x; x++)
                {
                    for (int y = prevPosition.y; y < prevPosition.y + item.Size.y; y++)
                    {
                        _grid[x, y] = item;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Reorganizes a inventory space so that the free area is uniform
        /// </summary>
        public void ReorganizeSpace()
        {
            _grid = new Item[_width, _height];
            _count = 0;

            List<Item> sortedItems = new List<Item>(_items);
            sortedItems.Sort((a, b) => (b.Size.x * b.Size.y).CompareTo(a.Size.x * a.Size.y));
                                                         
            foreach (var item in sortedItems)
            {               
                bool placed = false;
        
                for (int y = 0; y <= _height - item.Size.y; y++)
                {
                    for (int x = 0; x <= _width - item.Size.x; x++)
                    {
                        if (CanPlaceItemAt(item, x, y))
                        {
                            PlaceItemAt(item, x, y);
                            placed = true;
                            break;
                        }
                    }

                    if (placed) 
                        break;
                }
            }
        }

        private bool CanPlaceItemAt(Item item, int startX, int startY)
        {
            for (int y = startY; y < startY + item.Size.y; y++)
            {
                for (int x = startX; x < startX + item.Size.x; x++)
                {
                    if (_grid[x, y] != null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void PlaceItemAt(Item item, int startX, int startY)
        {
            for (int y = startY; y < startY + item.Size.y; y++)
            {
                for (int x = startX; x < startX + item.Size.x; x++)
                {
                    _grid[x, y] = item;
                }
            }
    
            _count++;
            _items.Add(item);
            OnAdded?.Invoke(item, new Vector2Int(startX, startY));
        }

        /// <summary>
        /// Copies inventory items to a specified matrix
        /// </summary>
        public void CopyTo(in Item[,] matrix)
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    matrix[x, y] = _grid[x, y];
                }
            }
        }

        public IEnumerator<Item> GetEnumerator()
        {
            foreach (var item in _items)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return _items.GetEnumerator();
        }
    }
}