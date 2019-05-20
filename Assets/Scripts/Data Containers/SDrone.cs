﻿using System.Collections;
using System.Collections.Generic;
using System;
namespace Drones.Serializable
{
    using Utils;
    [Serializable]
    public class SDrone
    {
        public uint count;
        public uint uid;
        public string name;
        public uint totalDeliveryCount;
        public uint totalBatterySwaps;
        public uint totalHubHandovers;
        public bool collisionOn;
        public bool isWaiting;
        public bool inHub;
        public DroneMovement movement;
        public FlightStatus status;
        public List<uint> completedJobs;
        public List<SVector3> waypointsQueue;
        public SVector3 position;
        public SVector3 previousWaypoint;
        public SVector3 waypoint;
        public SVector3 hubPosition;
        public uint job;
        public uint hub;
        public uint battery;
        public float charge;
        public float totalDelay;
        public float totalAudibleDuration;
        public float totalPackageWeight;
        public float totalDistanceTravelled;
        public float totalEnergy;
        public float targetAltitude;
        public float maxSpeed;

    }


}