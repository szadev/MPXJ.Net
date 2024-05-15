﻿namespace MPXJ.Net
{
    public class OpenPlanReader : AbstractProjectReader
    {
        public OpenPlanReader()
        {
            base.JavaObject = new net.sf.mpxj.openplan.OpenPlanReader();
        }

        public new net.sf.mpxj.openplan.OpenPlanReader JavaObject => (net.sf.mpxj.openplan.OpenPlanReader)base.JavaObject;
    }
}