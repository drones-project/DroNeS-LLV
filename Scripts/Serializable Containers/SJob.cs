﻿using System;
using Drones.Utils;

namespace Drones.Serializable
{
    [Serializable]
    public class SCostFunction
    {
        public float valid_time; // seconds
        public float reward;
    }

    [Serializable]
    public class SJob
    {
        // Generator set
        public uint uid;
        public JobStatus status;
        public long creationTime;
        public string content;
        public float packageWeight;
        public float packageXarea;
        public SCostFunction costFunction;
        public SVector3 pickup;
        public SVector3 destination;
        // Scheduler set
        public uint droneUID;
        // Unity set
        public STime deadline;
        public STime completedOn;
        public STime createdUnity;
        public STime assignedTime;
    }
}
