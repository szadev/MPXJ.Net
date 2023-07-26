﻿using NUnit.Framework;

namespace org.mpxj
{
	public class ProjectPropertiesTest
	{
        [Test]
        public void Test1()
        {
            var project = new UniversalProjectReader().Read("/Users/joniles/Downloads/three-tasks.mpp");
            Assert.That(project, Is.Not.Null);

            var props = project.ProjectProperties;
            Assert.That(props, Is.Not.Null);
            Assert.That(props.AMText, Is.EqualTo("am"));
        }
    }
}

