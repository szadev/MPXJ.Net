﻿using NUnit.Framework;

namespace org.mpxj
{
    public class WorkContourContainerTest
    {
        [Test]
        public void MethodsTest()
        {
            var file = new ProjectFile();
            Assert.That(file.WorkContours, Is.Empty);

            file.WorkContours.Add(WorkContour.Flat);
            Assert.That(file.WorkContours, Has.Count.EqualTo(1));

            var contour = file.WorkContours.GetByUniqueID(WorkContour.Flat.UniqueID);
            Assert.That(contour.Name, Is.EqualTo("FLAT"));

            Assert.That(file.WorkContours.JavaObject, Is.Not.Null);
        }
    }
}
