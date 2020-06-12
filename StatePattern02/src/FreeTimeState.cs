using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern02.src
{
    class FreeTimeState : IRoomState
    {
        private RoomContext _roomContext;
        public FreeTimeState(RoomContext roomContext)
        {
            _roomContext = roomContext;
        }

        public void BookRoom()
        {
            Console.WriteLine("预订房间成功。。。");
            _roomContext.State = new BookedState(_roomContext);
        }

        public void CheckInRoom()
        {
            Console.WriteLine("入住房间成功。。。");
            _roomContext.State = new CheckInState(_roomContext);
        }

        public void CheckOutRoom()
        {
            Console.WriteLine("无此操作。。。");
        }

        public void UnSubscribeRoom()
        {
            Console.WriteLine("无此操作。。。");
        }
    }
}
