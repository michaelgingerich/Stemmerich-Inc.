using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawMaterialsThresholdNotifier
{
    [Serializable()]
    class RawMaterial
    {
        public static List<RawMaterial> rawMaterialList = new List<RawMaterial>();
        int itemID;
        Boolean notify;

        public RawMaterial(int itemIDParam, Boolean notifyParam)
        {
            this.itemID = itemIDParam;
            this.notify = notifyParam;
        }

        public int getItemID()
        {
            return this.itemID;
        }

        public Boolean getNotify()
        {
            return this.notify;
        }
    }
}
