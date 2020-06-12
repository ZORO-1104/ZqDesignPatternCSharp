using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern02.src
{
    class RoomContext
    {
        private IRoomState _state;

        public IRoomState State
        {
            get => _state;
            set => _state = value;
        }

        //private IRoomState _freeTimeState;
        //private IRoomState _bookedState;
        //private IRoomState _checkInState;

        public RoomContext()
        {
            //_freeTimeState = new FreeTimeState(this);
            //_bookedState = new BookedState(this);
            //_checkInState = new CheckInState(this);

            ////初始状态为空房间
            //_state = _freeTimeState;

            _state = new FreeTimeState(this); ;
        }


        public void BookRoom()
        {
            _state.BookRoom();
        }

        //退订房间
        public void UnSubscribeRoom()
        {
            _state.UnSubscribeRoom();
        }

        //入住
        public void CheckInRoom()
        {
            _state.CheckInRoom();
        }

        //退房
        public void CheckOutRoom()
        {
            _state.CheckOutRoom();
        }

        public string GetState()
        {
            return _state.GetType().Name;
        }
    }
}
