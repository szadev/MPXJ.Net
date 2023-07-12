﻿using org.mpxj.proxy;

namespace org.mpxj
{
    public class CostAccount : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.CostAccount>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.CostAccount JavaObject { get; }

        internal CostAccount(ProxyManager proxyManager, net.sf.mpxj.CostAccount javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public CostAccount(ProjectFile file, java.lang.Integer uniqueID, string id, string name, string description, java.lang.Integer sequenceNumber)
        {
            _proxyManager = file._proxyManager;
            JavaObject = new net.sf.mpxj.CostAccount(uniqueID, id, name, description, sequenceNumber);
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public string ID => JavaObject.getID();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();

        public java.lang.Integer SequenceNumber => JavaObject.getSequenceNumber();

        public java.lang.Integer ParentUniqueID => JavaObject.getParentUniqueID();

        public CostAccount Parent
        {
            get => _proxyManager.ProxyObject(JavaObject.getParent());
            set => JavaObject.setParent(value.JavaObject);
        }

        public override string ToString() => JavaObject.toString();
    }
}

