﻿using JT808.Protocol.Enums;
using JT808.Protocol.Extensions;
using JT808.Protocol.Formatters;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JT808.Protocol.MessageBody.CarDVR
{
    /// <summary>
    /// 采集记录仪实时时间
    /// 返回：实时时间
    /// </summary>
    public class JT808_CarDVR_Down_0x02 : JT808CarDVRDownBodies
    {
        public override byte CommandId =>  JT808CarDVRCommandID.采集记录仪实时时间.ToByteValue();
         
        public override string Description => "实时时间";

        public override bool SkipSerialization { get; set; } = true;

        public override JT808CarDVRDownBodies Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            throw new NotImplementedException();
        }

        public override void Serialize(ref JT808MessagePackWriter writer, JT808CarDVRDownBodies value, IJT808Config config)
        {
            throw new NotImplementedException();
        }
    }
}
