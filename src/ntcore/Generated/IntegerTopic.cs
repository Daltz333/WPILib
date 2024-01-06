﻿// Copyright (c) FIRST and other WPILib contributors.
// Open Source Software; you can modify and/or share it under the terms of
// the WPILib BSD license file in the root directory of this project.

// THIS FILE WAS AUTO-GENERATED BY ./ntcore/generate_topics.py. DO NOT MODIFY

using NetworkTables.Natives;

namespace NetworkTables;

/** NetworkTables Integer topic. */
public class IntegerTopic : Topic
{
    /** The default type string for this topic type. */
    public static readonly string kTypeString = "int";

    /**
     * Construct from a generic topic.
     *
     * @param topic Topic
     */
    public IntegerTopic(Topic topic) : base(topic.Instance, topic.Handle)
    {
    }

    /**
     * Constructor; use NetworkTableInstance.getIntegerTopic() instead.
     *
     * @param inst Instance
     * @param handle Native handle
     */
    public IntegerTopic(NetworkTableInstance inst, int handle) : base(inst, handle)
    {
    }

    /**
     * Create a new subscriber to the topic.
     *
     * <p>The subscriber is only active as long as the returned object
     * is not closed.
     *
     * <p>Subscribers that do not match the published data type do not return
     * any values. To determine if the data type matches, use the appropriate
     * Topic functions.
     *
     * @param defaultValue default value used when a default is not provided to a
     *        getter function
     * @param options subscribe options
     * @return subscriber
     */
    public IntegerSubscriber Subscribe(
        long defaultValue,
        PubSubOptions options)
    {
        return new IntegerEntryImpl(
            this,
            NtCore.Subscribe(
                Handle, NetworkTableType.Integer,
                "int", options),
            defaultValue);
    }

    /**
     * Create a new subscriber to the topic, with specified type string.
     *
     * <p>The subscriber is only active as long as the returned object
     * is not closed.
     *
     * <p>Subscribers that do not match the published data type do not return
     * any values. To determine if the data type matches, use the appropriate
     * Topic functions.
     *
     * @param typeString type string
     * @param defaultValue default value used when a default is not provided to a
     *        getter function
     * @param options subscribe options
     * @return subscriber
     */
    public IntegerSubscriber SubscribeEx(
        string typeString,
        long defaultValue,
        PubSubOptions options)
    {
        return new IntegerEntryImpl(
            this,
            NtCore.Subscribe(
                Handle, NetworkTableType.Integer,
                typeString, options),
            defaultValue);
    }

    /**
     * Create a new publisher to the topic.
     *
     * <p>The publisher is only active as long as the returned object
     * is not closed.
     *
     * <p>It is not possible to publish two different data types to the same
     * topic. Conflicts between publishers are typically resolved by the server on
     * a first-come, first-served basis. Any published values that do not match
     * the topic's data type are dropped (ignored). To determine if the data type
     * matches, use the appropriate Topic functions.
     *
     * @param options publish options
     * @return publisher
     */
    public IntegerPublisher Publish(
        PubSubOptions options)
    {
        return new IntegerEntryImpl(
            this,
            NtCore.Publish(
                Handle, NetworkTableType.Integer,
                "int", options),
            0);
    }

    /**
     * Create a new publisher to the topic, with type string and initial properties.
     *
     * <p>The publisher is only active as long as the returned object
     * is not closed.
     *
     * <p>It is not possible to publish two different data types to the same
     * topic. Conflicts between publishers are typically resolved by the server on
     * a first-come, first-served basis. Any published values that do not match
     * the topic's data type are dropped (ignored). To determine if the data type
     * matches, use the appropriate Topic functions.
     *
     * @param typeString type string
     * @param properties JSON properties
     * @param options publish options
     * @return publisher
     * @throws IllegalArgumentException if properties is not a JSON object
     */
    public IntegerPublisher PublishEx(
        string typeString,
        string properties,
        PubSubOptions options)
    {
        return new IntegerEntryImpl(
            this,
            NtCore.PublishEx(
                Handle, NetworkTableType.Integer,
                typeString, properties, options),
            0);
    }

    /**
     * Create a new entry for the topic.
     *
     * <p>Entries act as a combination of a subscriber and a weak publisher. The
     * subscriber is active as long as the entry is not closed. The publisher is
     * created when the entry is first written to, and remains active until either
     * unpublish() is called or the entry is closed.
     *
     * <p>It is not possible to use two different data types with the same
     * topic. Conflicts between publishers are typically resolved by the server on
     * a first-come, first-served basis. Any published values that do not match
     * the topic's data type are dropped (ignored), and the entry will show no new
     * values if the data type does not match. To determine if the data type
     * matches, use the appropriate Topic functions.
     *
     * @param defaultValue default value used when a default is not provided to a
     *        getter function
     * @param options publish and/or subscribe options
     * @return entry
     */
    public IntegerEntry GetEntry(
        long defaultValue,
        PubSubOptions options)
    {
        return new IntegerEntryImpl(
            this,
            NtCore.GetEntry(
                Handle, NetworkTableType.Integer,
                "int", options),
            defaultValue);
    }

    /**
     * Create a new entry for the topic, with specified type string.
     *
     * <p>Entries act as a combination of a subscriber and a weak publisher. The
     * subscriber is active as long as the entry is not closed. The publisher is
     * created when the entry is first written to, and remains active until either
     * unpublish() is called or the entry is closed.
     *
     * <p>It is not possible to use two different data types with the same
     * topic. Conflicts between publishers are typically resolved by the server on
     * a first-come, first-served basis. Any published values that do not match
     * the topic's data type are dropped (ignored), and the entry will show no new
     * values if the data type does not match. To determine if the data type
     * matches, use the appropriate Topic functions.
     *
     * @param typeString type string
     * @param defaultValue default value used when a default is not provided to a
     *        getter function
     * @param options publish and/or subscribe options
     * @return entry
     */
    public IntegerEntry GetEntryEx(
        string typeString,
        long defaultValue,
        PubSubOptions options)
    {
        return new IntegerEntryImpl(
            this,
            NtCore.GetEntry(
                Handle, NetworkTableType.Integer,
                typeString, options),
            defaultValue);
    }

}
