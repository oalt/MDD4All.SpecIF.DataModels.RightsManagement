﻿/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MDD4All.SpecIF.DataModels.RightsManagement
{
	public class ApplicationRole
	{
		[BsonId]
		[BsonRepresentation(BsonType.String)]
		public string Id { get; set; } = Guid.NewGuid().ToString();

		[BsonElement("name")]
		public string Name { get; set; }

		[BsonElement("normalizedName")]
		public string NormalizedName { get; set; }
	}
}
