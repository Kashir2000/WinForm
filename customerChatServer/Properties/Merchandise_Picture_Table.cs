//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace customerChatServer.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class Merchandise_Picture_Table
    {
        public int MerchandisePicID { get; set; }
        public int IngredientID { get; set; }
        public byte[] MerchandisePicture { get; set; }
    
        public virtual Ingredient_Table Ingredient_Table { get; set; }
    }
}
