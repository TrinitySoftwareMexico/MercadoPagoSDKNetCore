using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
    public struct PaymentMethod
    {
        #region Properties 
        [StringLength(256)]
        private string _id; 
        #endregion

        #region Accessors
        /// <summary>
        /// Payment method ID
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        } 
        #endregion
    }
}
