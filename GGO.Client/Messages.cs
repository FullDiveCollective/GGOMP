﻿using CitizenFX.Core.Native;

namespace GGO.Client
{
    public static class Messages
    {
        public static void Phone(string Contact, string Message, string Author = "GGO")
        {
            API.SetNotificationTextEntry("STRING");
            API.AddTextComponentString(Message);
            API.SetNotificationMessage(Contact, Contact, false, 1, Author, "");
            API.DrawNotification(false, true);
        }

        public static void Notification(string Message)
        {
            API.SetNotificationTextEntry("CELL_EMAIL_BCON");
            API.AddTextComponentString(Message);
            API.DrawNotification(false, true);
        }
    }
}
