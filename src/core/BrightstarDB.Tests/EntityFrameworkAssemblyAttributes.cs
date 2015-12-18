﻿#if !NETFX_CORE // Portable version of BrightstarDB does not currently contain EntityFramework
using BrightstarDB.EntityFramework;

[assembly: NamespaceDeclaration("dc", "http://purl.org/dc/terms/")]
[assembly: NamespaceDeclaration("foaf", "http://xmlns.com/foaf/0.1/")]
[assembly: NamespaceDeclaration("bsi", "http://brightstardb.com/instances/")]
[assembly: TypeIdentifierPrefix("http://www.example.org/schema/")]
[assembly: GenerateInternalEntityClasses]
#endif