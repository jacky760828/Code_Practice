using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter_face
{
    internal class village : creature,I_Talk
    {
        public override string Getneme()
        {
            return "玩家";
        }
        public override string say()
        {
            return "你好啊,我是"+Getneme();
        }

        public string TalkTo(creature target)
        {
            return "你好啊,"+target.Getneme()+"I am Player";
        }
    }
}
