using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    class Outside:Location
    {
        bool hot;
        public bool Hot
        {
            get
            {
                return hot;
            }
        }

        public Outside(string name , bool hot):base(name)
        {
            this.hot = hot;
        }
        public override string Description
        {
            get
            {
                string hotInfo;
                if (hot)
                    hotInfo= "Tutaj jest gorąco! ";
                else
                    hotInfo= "Tu jest chłodno. ";

                return base.Description + hotInfo;
            }

        }

    }
}
