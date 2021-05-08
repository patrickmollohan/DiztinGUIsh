﻿using Diz.Core.model.project;

namespace Diz.Core.serialization.xml_serializer
{
    public interface IMigrationEvents
    {
        // add migrations to hook in various places in the code as needed.
        // example: something to pre-process incoming XML text, or modify the XML deserializer before it's used
        
        void OnLoadingBeforeAddLinkedRom(AddRomDataCommand romAddCmd);
        void OnLoadingAfterAddLinkedRom(AddRomDataCommand romAddCmd);
    }
    
    public interface IMigration : IMigrationEvents
    {
        // Each Migration has a unique version#, and will upgrade data in that version#
        // to the next version#.
        public int AppliesToSaveVersion { get; }
    }

    public interface IMigrationRunner : IMigrationEvents
    {
        
    }
}