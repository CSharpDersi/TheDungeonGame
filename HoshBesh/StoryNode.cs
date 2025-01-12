using HoshBesh;
using HoshBesh.Floors;
namespace HoshBesh
{
    internal class StoryNode
    {
        public string Description { get; set; }
        public Dictionary<string, StoryNode> Options { get; set; }
        public bool RequiresInput { get; set; }
        public List<string>? OptionsDescriptions { get; set; }

        public StoryNode(string description)
        {
            Description = description;
            Options = new Dictionary<string, StoryNode>();
            RequiresInput = false;
            OptionsDescriptions = null;
        }
    }
}
