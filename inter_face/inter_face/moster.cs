using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter_face
{
    class Monster : creature,I_Attack_able
    {
        public void attack(creature target)
        {
          target.injure(20);
        }

        public override string Getneme()
        {
            return "怪物";
                
        }
        public override string say()
        {
            return "恐恐恐,有"+hp+"滴血";
        }
       
    }
}
