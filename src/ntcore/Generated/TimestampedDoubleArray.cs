﻿// Copyright (c) FIRST and other WPILib contributors.
// Open Source Software; you can modify and/or share it under the terms of
// the WPILib BSD license file in the root directory of this project.

// THIS FILE WAS AUTO-GENERATED BY ./ntcore/generate_topics.py. DO NOT MODIFY

namespace NetworkTables;

/** NetworkTables timestamped DoubleArray. */
public sealed class TimestampedDoubleArray
{
    /**
     * Create a timestamped value.
     *
     * @param timestamp timestamp in local time base
     * @param serverTime timestamp in server time base
     * @param value value
     */
    public TimestampedDoubleArray(long timestamp, long serverTime, double[] value)
    {
        Timestamp = timestamp;
        ServerTime = serverTime;
        Value = value;
    }

    /**
     * Timestamp in local time base.
     */
    public long Timestamp { get; }

    /**
     * Timestamp in server time base.  May be 0 or 1 for locally set values.
     */
    public long ServerTime { get; }

    /**
     * Value.
     */
    public double[] Value { get; }
}
