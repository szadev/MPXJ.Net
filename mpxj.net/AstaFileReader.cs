﻿namespace MPXJ.Net
{
    public class AstaFileReader : AbstractProjectReader
    {
        public AstaFileReader()
        {
            base.JavaObject = new net.sf.mpxj.asta.AstaFileReader();
        }

        public new net.sf.mpxj.asta.AstaFileReader JavaObject => (net.sf.mpxj.asta.AstaFileReader)base.JavaObject;
    }
}