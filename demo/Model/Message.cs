﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 20/12/2018 7:41:07 μμ
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace IMModel
{

    /// <summary>
    /// There are no comments for IMModel.Message in the schema.
    /// </summary>
    public partial class Message    {

        public Message()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for MessageId in the schema.
        /// </summary>
        public virtual int MessageId
        {
            get;
            set;
        }
        public int Messageid { get; internal set; }


        /// <summary>
        /// There are no comments for Userid in the schema.
        /// </summary>
        public virtual int Userid
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Sender in the schema.
        /// </summary>
        public virtual string Sender
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Receiver in the schema.
        /// </summary>
        public virtual string Receiver
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Date in the schema.
        /// </summary>
        public virtual global::System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Data in the schema.
        /// </summary>
        public virtual string Data
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        public virtual User User
        {
            get;
            set;
        }

        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}