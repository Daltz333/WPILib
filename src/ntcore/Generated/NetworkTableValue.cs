﻿// Copyright (c) FIRST and other WPILib contributors.
// Open Source Software; you can modify and/or share it under the terms of
// the WPILib BSD license file in the root directory of this project.

// THIS FILE WAS AUTO-GENERATED BY ./ntcore/generate_topics.py. DO NOT MODIFY

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using NetworkTables.Natives;

namespace NetworkTables;

/** A network table entry value. */
[NativeMarshalling(typeof(NtValueMarshaller))]
[StructLayout(LayoutKind.Auto)]
public readonly struct NetworkTableValue
{
    internal NetworkTableValue(in NtValue value) {

    }

    public NtValue ToNative() {
        return new NtValue();
    }


    internal NetworkTableValue(NetworkTableType type, object? obj, long time, long serverTime)
    {
        Type = type;
        Time = time;
        ServerTime = serverTime;
        m_objectValue = obj;
    }

    internal NetworkTableValue(NetworkTableType type, long value) : this(type, null, NtCore.Now(), 1)
    {
        m_longValue = value;
    }

    internal NetworkTableValue(NetworkTableType type, float value) : this(type, null, NtCore.Now(), 1)
    {
        m_floatValue = value;
    }

    internal NetworkTableValue(NetworkTableType type, double value) : this(type, null, NtCore.Now(), 1)
    {
        m_doubleValue = value;
    }

    internal NetworkTableValue(NetworkTableType type, object value) : this(type, value, NtCore.Now(), 1) { }

    internal NetworkTableValue(NetworkTableType type, long value, long time) : this(type, null, NtCore.Now(), 1)
    {
        m_longValue = value;
    }

    internal NetworkTableValue(NetworkTableType type, float value, long time) : this(type, null, NtCore.Now(), 1)
    {
        m_floatValue = value;
    }

    internal NetworkTableValue(NetworkTableType type, double value, long time) : this(type, null, NtCore.Now(), 1)
    {
        m_doubleValue = value;
    }

    internal NetworkTableValue(NetworkTableType type, object value, long time) : this(type, value, time, 1)
    {
    }


    /**
     * Get the data type.
     *
     * @return The type.
     */
    public NetworkTableType Type { get; }

    /**
     * Get the data value stored.
     *
     * @return The type.
     */
    public object? Value
    {
        get
        {
            if (m_objectValue != null)
            {
                return m_objectValue;
            }
            // TODO load value
            return null;
        }
    }

    /**
     * Get the creation time of the value in local time.
     *
     * @return The time, in the units returned by NtCore.Now().
     */
    public long Time { get; }

    /**
     * Get the creation time of the value in server time.
     *
     * @return The server time.
     */
    public long ServerTime { get; }

    /*
     * Type Checkers
     */

    /**
     * Determine if entry value contains a value or is unassigned.
     *
     * @return True if the entry value contains a value.
     */
    public bool IsValid => Type != NetworkTableType.Unassigned;


    /**
     * Determine if entry value contains a bool.
     *
     * @return True if the entry value is of bool type.
     */
    public bool IsBoolean => Type == NetworkTableType.Boolean;

    /**
     * Determine if entry value contains a long.
     *
     * @return True if the entry value is of long type.
     */
    public bool IsInteger => Type == NetworkTableType.Integer;

    /**
     * Determine if entry value contains a float.
     *
     * @return True if the entry value is of float type.
     */
    public bool IsFloat => Type == NetworkTableType.Float;

    /**
     * Determine if entry value contains a double.
     *
     * @return True if the entry value is of double type.
     */
    public bool IsDouble => Type == NetworkTableType.Double;

    /**
     * Determine if entry value contains a string.
     *
     * @return True if the entry value is of string type.
     */
    public bool IsString => Type == NetworkTableType.String;

    /**
     * Determine if entry value contains a byte[].
     *
     * @return True if the entry value is of byte[] type.
     */
    public bool IsRaw => Type == NetworkTableType.Raw;

    /**
     * Determine if entry value contains a bool[].
     *
     * @return True if the entry value is of bool[] type.
     */
    public bool IsBooleanArray => Type == NetworkTableType.BooleanArray;

    /**
     * Determine if entry value contains a long[].
     *
     * @return True if the entry value is of long[] type.
     */
    public bool IsIntegerArray => Type == NetworkTableType.IntegerArray;

    /**
     * Determine if entry value contains a float[].
     *
     * @return True if the entry value is of float[] type.
     */
    public bool IsFloatArray => Type == NetworkTableType.FloatArray;

    /**
     * Determine if entry value contains a double[].
     *
     * @return True if the entry value is of double[] type.
     */
    public bool IsDoubleArray => Type == NetworkTableType.DoubleArray;

    /**
     * Determine if entry value contains a string[].
     *
     * @return True if the entry value is of string[] type.
     */
    public bool IsStringArray => Type == NetworkTableType.StringArray;

    /*
     * Type-Safe Getters
     */

    /**
     * Get the bool value.
     *
     * @return The bool value.
     * @throws ClassCastException if the entry value is not of bool type.
     */
    public bool GetBoolean()
    {
        if (Type != NetworkTableType.Boolean)
        {
            throw new InvalidCastException($"cannot convert {Type} to bool");
        }
        return m_longValue != 0;
    }

    /**
     * Get the long value.
     *
     * @return The long value.
     * @throws ClassCastException if the entry value is not of long type.
     */
    public long GetInteger()
    {
        if (Type != NetworkTableType.Integer)
        {
            throw new InvalidCastException($"cannot convert {Type} to long");
        }
        return m_longValue;
    }

    /**
     * Get the float value.
     *
     * @return The float value.
     * @throws ClassCastException if the entry value is not of float type.
     */
    public float GetFloat()
    {
        if (Type != NetworkTableType.Float)
        {
            throw new InvalidCastException($"cannot convert {Type} to float");
        }
        return m_floatValue;
    }

    /**
     * Get the double value.
     *
     * @return The double value.
     * @throws ClassCastException if the entry value is not of double type.
     */
    public double GetDouble()
    {
        if (Type != NetworkTableType.Double)
        {
            throw new InvalidCastException($"cannot convert {Type} to double");
        }
        return m_doubleValue;
    }

    /**
     * Get the string value.
     *
     * @return The string value.
     * @throws ClassCastException if the entry value is not of string type.
     */
    public string GetString()
    {
        if (Type != NetworkTableType.String)
        {
            throw new InvalidCastException($"cannot convert {Type} to string");
        }
        return (string)m_objectValue!;
    }

    /**
     * Get the byte[] value.
     *
     * @return The byte[] value.
     * @throws ClassCastException if the entry value is not of byte[] type.
     */
    public byte[] GetRaw()
    {
        if (Type != NetworkTableType.Raw)
        {
            throw new InvalidCastException($"cannot convert {Type} to byte[]");
        }
        return (byte[])m_objectValue!;
    }

    /**
     * Get the bool[] value.
     *
     * @return The bool[] value.
     * @throws ClassCastException if the entry value is not of bool[] type.
     */
    public bool[] GetBooleanArray()
    {
        if (Type != NetworkTableType.BooleanArray)
        {
            throw new InvalidCastException($"cannot convert {Type} to bool[]");
        }
        return (bool[])m_objectValue!;
    }

    /**
     * Get the long[] value.
     *
     * @return The long[] value.
     * @throws ClassCastException if the entry value is not of long[] type.
     */
    public long[] GetIntegerArray()
    {
        if (Type != NetworkTableType.IntegerArray)
        {
            throw new InvalidCastException($"cannot convert {Type} to long[]");
        }
        return (long[])m_objectValue!;
    }

    /**
     * Get the float[] value.
     *
     * @return The float[] value.
     * @throws ClassCastException if the entry value is not of float[] type.
     */
    public float[] GetFloatArray()
    {
        if (Type != NetworkTableType.FloatArray)
        {
            throw new InvalidCastException($"cannot convert {Type} to float[]");
        }
        return (float[])m_objectValue!;
    }

    /**
     * Get the double[] value.
     *
     * @return The double[] value.
     * @throws ClassCastException if the entry value is not of double[] type.
     */
    public double[] GetDoubleArray()
    {
        if (Type != NetworkTableType.DoubleArray)
        {
            throw new InvalidCastException($"cannot convert {Type} to double[]");
        }
        return (double[])m_objectValue!;
    }

    /**
     * Get the string[] value.
     *
     * @return The string[] value.
     * @throws ClassCastException if the entry value is not of string[] type.
     */
    public string[] GetStringArray()
    {
        if (Type != NetworkTableType.StringArray)
        {
            throw new InvalidCastException($"cannot convert {Type} to string[]");
        }
        return (string[])m_objectValue!;
    }

    /*
     * Factory functions.
     */

    /**
     * Creates a bool value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeBoolean(bool value)
    {
        return new NetworkTableValue(NetworkTableType.Boolean, value ? 1 : 0);
    }

    /**
     * Creates a bool value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeBoolean(bool value, long time)
    {
        return new NetworkTableValue(NetworkTableType.Boolean, value ? 1 : 0, time);
    }


    /**
     * Creates a long value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeInteger(long value)
    {
        return new NetworkTableValue(NetworkTableType.Integer, value);
    }

    /**
     * Creates a long value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeInteger(long value, long time)
    {
        return new NetworkTableValue(NetworkTableType.Integer, value, time);
    }


    /**
     * Creates a float value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeFloat(float value)
    {
        return new NetworkTableValue(NetworkTableType.Float, value);
    }

    /**
     * Creates a float value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeFloat(float value, long time)
    {
        return new NetworkTableValue(NetworkTableType.Float, value, time);
    }


    /**
     * Creates a double value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeDouble(double value)
    {
        return new NetworkTableValue(NetworkTableType.Double, value);
    }

    /**
     * Creates a double value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeDouble(double value, long time)
    {
        return new NetworkTableValue(NetworkTableType.Double, value, time);
    }


    /**
     * Creates a string value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeString(string value)
    {
        return new NetworkTableValue(NetworkTableType.String, value);
    }

    /**
     * Creates a string value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeString(string value, long time)
    {
        return new NetworkTableValue(NetworkTableType.String, value, time);
    }


    /**
     * Creates a byte[] value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeRaw(byte[] value)
    {
        return new NetworkTableValue(NetworkTableType.Raw, value);
    }

    /**
     * Creates a byte[] value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeRaw(byte[] value, long time)
    {
        return new NetworkTableValue(NetworkTableType.Raw, value, time);
    }


    /**
     * Creates a bool[] value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeBooleanArray(bool[] value)
    {
        return new NetworkTableValue(NetworkTableType.BooleanArray, value);
    }

    /**
     * Creates a bool[] value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeBooleanArray(bool[] value, long time)
    {
        return new NetworkTableValue(NetworkTableType.BooleanArray, value, time);
    }


    /**
     * Creates a long[] value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeIntegerArray(long[] value)
    {
        return new NetworkTableValue(NetworkTableType.IntegerArray, value);
    }

    /**
     * Creates a long[] value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeIntegerArray(long[] value, long time)
    {
        return new NetworkTableValue(NetworkTableType.IntegerArray, value, time);
    }


    /**
     * Creates a float[] value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeFloatArray(float[] value)
    {
        return new NetworkTableValue(NetworkTableType.FloatArray, value);
    }

    /**
     * Creates a float[] value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeFloatArray(float[] value, long time)
    {
        return new NetworkTableValue(NetworkTableType.FloatArray, value, time);
    }


    /**
     * Creates a double[] value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeDoubleArray(double[] value)
    {
        return new NetworkTableValue(NetworkTableType.DoubleArray, value);
    }

    /**
     * Creates a double[] value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeDoubleArray(double[] value, long time)
    {
        return new NetworkTableValue(NetworkTableType.DoubleArray, value, time);
    }


    /**
     * Creates a string[] value.
     *
     * @param value the value
     * @return The entry value
     */
    public static NetworkTableValue MakeStringArray(string[] value)
    {
        return new NetworkTableValue(NetworkTableType.StringArray, value);
    }

    /**
     * Creates a string[] value.
     *
     * @param value the value
     * @param time the creation time to use (instead of the current time)
     * @return The entry value
     */
    public static NetworkTableValue MakeStringArray(string[] value, long time)
    {
        return new NetworkTableValue(NetworkTableType.StringArray, value, time);
    }



    // TODO Generate equals

    private readonly object? m_objectValue;
    private readonly long m_longValue;
    private readonly float m_floatValue;
    private readonly double m_doubleValue;
}
