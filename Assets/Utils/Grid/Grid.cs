using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid<T>
{
    public int Row { get { return _row; } }

    public int Column { get { return _column; } }

    int _row;
    int _column;
    T[,] _values;

    public Grid(int row, int column)
    {
        _row = row;
        _column = column;
        _values = new T[row, column];
    }

    public T Get(int row, int column)
    {
        return !IsValidRow(row) || !IsValidRow(column) ? default(T) : _values[row, column];
    }

    public void GetRow(int row, List<T> values)
    {
        if (!IsValidRow(row)) return;

        values.Clear();

        for (int column = 0; column < _column; column++)
        {
            values.Add(_values[row, column]);
        }
    }

    public void GetColumn(int column, List<T> values)
    {
        if (!IsValidColumn(column)) return;

        values.Clear();

        for (int row = 0; row < _row; row++)
        {
            values.Add(_values[row, column]);
        }
    }

    public void Set(int row, int column, T value)
    {
        _values[row, column] = value;
    }

    public void SetRow(int row, List<T> values)
    {
        if (!IsValidRow(row) || values.Count != _column) return;

        for (int column = 0; column < _column; column++)
        {
            _values[row, column] = values[column];
        }
    }

    public void SetRow(int row, T[] values)
    {
        if (!IsValidRow(row) || values.Length != _column) return;

        for (int column = 0; column < _column; column++)
        {
            _values[row, column] = values[column];
        }
    }

    public void SetColumn(int column, List<T> values)
    {
        if (!IsValidColumn(column) || values.Count != _row) return;

        for (int row = 0; row < _row; row++)
        {
            _values[row, column] = values[row];
        }
    }

    public void SetColumn(int column, T[] values)
    {
        if (!IsValidColumn(column) || values.Length != _row) return;

        for (int row = 0; row < _row; row++)
        {
            _values[row, column] = values[row];
        }
    }

    public bool IsValid(int row, int column)
    {
        return IsValidRow(row) && IsValidColumn(column);
    }

    public bool IsValidRow(int row)
    {
        return 0 <= row && row < _row;
    }

    public bool IsValidColumn(int column)
    {
        return 0 <= column && column < _column;
    }

    public void ForEach(Action<T> action)
    {
        ForEachRow(action);
    }

    public void ForEachRow(Action<T> action)
    {
        if (action == null) return;

        for (int row = 0; row < _row; row++)
        {
            for (int column = 0; column < _column; column++)
            {
                action(_values[row, column]);
            }
        }
    }

    public void ForEachRow(int row, Action<T> action)
    {
        if (!IsValidRow(row) || action == null) return;

        for (int column = 0; column < _column; column++)
        {
            action(_values[row, column]);
        }
    }

    public void ForEachColumn(Action<T> action)
    {
        if (action == null) return;

        for (int column = 0; column < _column; column++)
        {
            for (int row = 0; row < _row; row++)
            {
                action(_values[row, column]);
            }
        }
    }

    public void ForEachColumn(int column, Action<T> action)
    {
        if (!IsValidColumn(column) || action == null) return;

        for (int row = 0; row < _row; row++)
        {
            action(_values[row, column]);
        }
    }
}
