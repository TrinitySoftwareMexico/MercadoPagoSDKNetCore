﻿namespace MercadoPago.DataStructures.Customer
{
    public struct City
    {
        #region Properties

        private string id;
        private string name;

        #endregion

        #region Accessors

        public string ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        #endregion
    }
}
