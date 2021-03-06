﻿using System;
using System.Linq;

using Draft.Responses;

namespace Draft.Tests
{
    internal static partial class Fixtures
    {

        public static class CompareAndSwap
        {

            public const int DefaultTtl = 300;

            public const long ExpectedIndex = 32;

            public const string ExpectedValue = "{B6D19813-0A6B-4D4A-9236-C56F6AB89DE6}";

            public const string NewValue = "{7564D465-FFA8-4431-B248-03372193E4D4}";

            public const string Path = "/foo/cas";

            public static readonly object DefaultResponse = new KeyData();

            public static string DefaultRequest(string value = NewValue)
            {
                return WithValue(value)
                    .AsRequestBody();
            }

            public static string TtlRequest(string value = NewValue, int ttl = DefaultTtl)
            {
                return WithValue(value)
                    .Add(Constants.Etcd.Parameter_Ttl, ttl)
                    .AsRequestBody();
            }

            private static FormBodyBuilder WithValue(string value)
            {
                return new FormBodyBuilder()
                    .Add(Constants.Etcd.Parameter_Value, value);
            }
        }

    }
}
