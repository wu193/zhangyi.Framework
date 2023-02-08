﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using ZeorStack.DeviceCenter.Domain.Aggregates.ProductAggregate;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.MeasurementAggregate
{
    public class MeasurementBucket : DynamicObject
    {
        public string Id { get; set; } = default!;

        public FeatureType FeatureType { get; set; }

        public string Identifier { get; set; } = default!;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Dictionary<string, object?> Metadata { get; set; } = new();

        public List<Measurement> Measurements { get; set; } = new();

        public DateTime LastUpdated { get; set; }

        public double? Sum { get; set; }

        public int Count { get; set; }

        public double? Min { get; set; }

        public double? Max { get; set; }

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            Metadata[binder.Name] = value;
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return Metadata.TryGetValue(binder.Name, out result);
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            foreach (var item in Metadata.Keys)
            {
                yield return item;
            }
        }
    }
}