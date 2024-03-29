﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voter.Api.Models
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("text")]
        public string Text { get; set; }

        [BsonElement("yes")]
        public int Yes { get; set; }

        [BsonElement("no")]
        public int No { get; set; }
    }
}
