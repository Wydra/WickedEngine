using System.Xml;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TiledPipelineExtensions
{
    public class ExternalTileSetContent : TileSetContent
    {
        public ExternalTileSetContent(XmlNode node, ContentImporterContext context)
            : base(node, context)
        {
        }

        protected override XmlNode PrepareXmlNode(XmlNode root)
        {
            XmlDocument externalTileSet = new XmlDocument();
            externalTileSet.Load(root.Attributes["source"].Value);
            return externalTileSet["tileset"];
        }
    }
}
