﻿using System.Runtime.Serialization;
using System.Windows.Forms;

namespace LM.UI.View.Forms.CommandItems
{
    internal class HiddenCheckBoxTreeNode : TreeNode
    {
        public HiddenCheckBoxTreeNode() { Checked = false; }

        public HiddenCheckBoxTreeNode(string text)
            : base(text) { }

        public HiddenCheckBoxTreeNode(string text, TreeNode[] children)
            : base(text, children) { }

        public HiddenCheckBoxTreeNode(string text, int imageIndex, int selectedImageIndex)
            : base(text, imageIndex, selectedImageIndex) { }

        public HiddenCheckBoxTreeNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children)
            : base(text, imageIndex, selectedImageIndex, children) { }

        protected HiddenCheckBoxTreeNode(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }
    }
}
