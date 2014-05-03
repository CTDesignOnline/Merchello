﻿using System.Linq;
using Merchello.Core.Triggers;
using Merchello.Tests.IntegrationTests.TestHelpers;
using NUnit.Framework;

namespace Merchello.Tests.IntegrationTests.ObjectResolution
{
    [TestFixture]
    public class EventTriggerResolution : MerchelloAllInTestBase
    {
        [Test]
        public void Can_Resolve_EventTriggers()
        {
            Assert.IsTrue(EventTriggerResolver.Current.Triggers.Any());
        }
    }
}