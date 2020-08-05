﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Djuwidja.GenericUtil.Patterns.IoC.Tests
{
    public class TestIoCObject
    {
        [Test]
        public void CanInitialize()
        {
            object obj = new object();
            IoCObject iocObject = new IoCObject(InstantiationType.SINGLETON, obj);

            Assert.AreEqual(InstantiationType.SINGLETON, iocObject.InstantiationType);
            Assert.AreSame(obj, iocObject.Object);
        }
    }
}
