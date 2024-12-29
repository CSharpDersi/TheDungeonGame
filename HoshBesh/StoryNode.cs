using System.Collections.Generic;

namespace The_HoshBesh.Classes
{
    internal class StoryNode
    {
        public string Description { get; set; }
        public Dictionary<string, StoryNode> Options { get; set; }

        public StoryNode(string description)
        {
            Description = description;
            Options = new Dictionary<string, StoryNode>();
        }
    }
}
