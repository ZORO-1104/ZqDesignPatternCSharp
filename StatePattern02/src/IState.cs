using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern02.src
{
    interface IRoomState
    {
        //预定房间
        void BookRoom();

        //退订房间
        void UnSubscribeRoom();

        //入住
        void CheckInRoom();

        //退房
        void CheckOutRoom();
    }
}
