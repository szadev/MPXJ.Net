﻿namespace MPXJ.Net
{
    public class TurboProjectReader : AbstractProjectReader
    {
        public TurboProjectReader()
        {
            base.JavaObject = new net.sf.mpxj.turboproject.TurboProjectReader();
        }

        public new net.sf.mpxj.turboproject.TurboProjectReader JavaObject => (net.sf.mpxj.turboproject.TurboProjectReader)base.JavaObject;
    }
}
