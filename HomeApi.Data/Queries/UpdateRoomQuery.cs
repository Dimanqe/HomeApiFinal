using System;

namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении комнаты
    /// </summary>
    public class UpdateRoomQuery
    {
        public string NewName { get; } 
        public int NewArea { get; }       
        public bool NewGasConnectionState { get; }
        public int NewVoltage { get; }       

        public UpdateRoomQuery( string newName = null, int newArea = 0, bool newGasConnectionState = false, int newVoltage = 0)
        {
            NewName = newName;
            NewArea = newArea;
            NewGasConnectionState = newGasConnectionState;
            NewVoltage = newVoltage;          
            
        }
    }
}