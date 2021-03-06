﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.Debugger.Metadata;
using Type = Microsoft.VisualStudio.Debugger.Metadata.Type;

namespace Microsoft.CodeAnalysis.ExpressionEvaluator
{
    internal sealed class AssemblyImpl : Assembly
    {
        public readonly System.Reflection.Assembly Assembly;

        public AssemblyImpl(System.Reflection.Assembly assembly)
        {
            Debug.Assert(assembly != null);
            this.Assembly = assembly;
        }

        public override AssemblyName[] GetReferencedAssemblies()
        {
            Debug.Assert(Assembly.GetReferencedAssemblies().Length == 0, "If this fires, we have to actually implement this method.");
            return new AssemblyName[0];
        }

        public override MethodInfo EntryPoint
        {
            get { throw new NotImplementedException(); }
        }

        public override string FullName
        {
            get { throw new NotImplementedException(); }
        }

        public override string Location
        {
            get { throw new NotImplementedException(); }
        }

        public override IList<CustomAttributeData> GetCustomAttributesData()
        {
            throw new NotImplementedException();
        }

        public override Type[] GetExportedTypes()
        {
            throw new NotImplementedException();
        }

        public override AssemblyName GetName()
        {
            throw new NotImplementedException();
        }

        public override AssemblyName GetName(bool copiedName)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetTypes()
        {
            throw new NotImplementedException();
        }
    }
}
