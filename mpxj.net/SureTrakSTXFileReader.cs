﻿namespace MPXJ.Net
{
    public class SureTrakSTXFileReader : AbstractProjectReader
    {
        public SureTrakSTXFileReader()
        {
            base.JavaObject = new net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader();
        }

        public new net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader JavaObject => (net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader)base.JavaObject;
    }
}