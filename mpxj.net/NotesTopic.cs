﻿using org.mpxj.proxy;

namespace org.mpxj
{
    public class NotesTopic : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.NotesTopic>
    {
        public net.sf.mpxj.NotesTopic JavaObject { get; }

        internal NotesTopic(net.sf.mpxj.NotesTopic javaObject)
        {
            JavaObject = javaObject;
        }

        public NotesTopic(int uniqueID, int sequenceNumber, string name, bool availableForEPS, bool availableForProject, bool availableForWBS, bool availableForActivity)
        {
            JavaObject = new net.sf.mpxj.NotesTopic(uniqueID.ConvertType(), sequenceNumber.ConvertType(), name, availableForEPS, availableForProject, availableForWBS, AvailableForActivity);
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public int SequenceNumber => JavaObject.getSequenceNumber().ConvertType().Value;

        public string Name => JavaObject.getName();

        public bool AvailableForEPS => JavaObject.getAvailableForEPS();

        public bool AvailableForProject => JavaObject.getAvailableForProject();

        public bool AvailableForWBS => JavaObject.getAvailableForWBS();

        public bool AvailableForActivity => JavaObject.getAvailableForActivity();
    }
}

