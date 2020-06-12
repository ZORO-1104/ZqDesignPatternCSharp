using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern03.src
{
    interface IRoomState
    {
        //预定房间
        void BookRoom(RoomContext roomContext);

        //退订房间
        void UnSubscribeRoom(RoomContext roomContext);

        //入住
        void CheckInRoom(RoomContext roomContext);

        //退房
        void CheckOutRoom(RoomContext roomContext);
    }
}
