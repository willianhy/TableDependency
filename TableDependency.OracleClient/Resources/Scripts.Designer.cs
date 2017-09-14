﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TableDependency.OracleClient.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Scripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Scripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TableDependency.OracleClient.Resources.Scripts", typeof(Scripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE OR REPLACE PROCEDURE DEQ_{0} (p_recordset OUT SYS_REFCURSOR) 
        ///AS 
        ///  payload TYPE_{0};
        ///  payload_table TBL_{0};
        ///  v_msgid RAW(16);
        ///  
        ///  queueopts DBMS_AQ.DEQUEUE_OPTIONS_T;
        ///  msgprops DBMS_AQ.MESSAGE_PROPERTIES_T;
        ///   
        ///  no_messages EXCEPTION;
        ///  PRAGMA EXCEPTION_INIT (no_messages, -25228);
        ///BEGIN
        ///  queueopts.wait := {1};
        ///  queueopts.navigation := DBMS_AQ.NEXT_MESSAGE;
        ///  payload_table := TBL_{0}();
        ///  
        ///  FOR Lcntr IN 1..{2} LOOP
        ///    BEGIN
        ///    
        ///      payload_table.EXTEND;
        ///      
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateProcedureDequeueMessage {
            get {
                return ResourceManager.GetString("CreateProcedureDequeueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE OR REPLACE TRIGGER TR_{0}
        ///AFTER {15}{1} ON {2}
        ///REFERENCING OLD AS OLD NEW AS NEW 
        ///FOR EACH ROW
        ///BEGIN
        ///  DECLARE
        ///    enqueue_options DBMS_AQ.enqueue_options_t;
        ///    message_properties DBMS_AQ.message_properties_t;
        ///    message_handle RAW(16);
        ///    message_buffer BLOB;
        ///    message_content TYPE_{0};
        ///    lob_loc BLOB;
        ///    l_clob CLOB;    
        ///    messageEnd VARCHAR2(50) := &apos;{6}&apos;;
        ///    messageStart VARCHAR2(50);
        ///    dmlType VARCHAR2(50);
        ///
        ///    l_dest_offset integer;
        ///    l_src_offset  integer;
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateTriggerEnqueueMessage {
            get {
                return ResourceManager.GetString("CreateTriggerEnqueueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///    DECLARE
        ///      v_object_type2 VARCHAR2(30);
        ///    BEGIN
        ///      SELECT   OBJECT_TYPE 
        ///      INTO     v_object_type2 
        ///      FROM     user_OBJECTS 
        ///      WHERE    OBJECT_TYPE = &apos;TRIGGER&apos; AND UPPER(OBJECT_NAME) = &apos;TR_{0}&apos;;
        ///
        ///      EXECUTE IMMEDIATE &apos;DROP TRIGGER TR_{0}&apos;;
        ///    EXCEPTION
        ///      WHEN OTHERS THEN
        ///        NULL;
        ///    END;
        ///
        ///    DECLARE
        ///      v_object_type3 VARCHAR2(30);
        ///    BEGIN
        ///      SELECT   OBJECT_TYPE 
        ///      INTO     v_object_type3 
        ///      FROM     user_OBJECTS 
        ///      WHERE  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ScriptDropAll {
            get {
                return ResourceManager.GetString("ScriptDropAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  DBMS_SCHEDULER.CREATE_JOB(
        ///    JOB_NAME =&gt; &apos;JOB_{0}&apos;,
        ///    JOB_TYPE =&gt; &apos;PLSQL_BLOCK&apos;,
        ///    JOB_ACTION =&gt; &apos;{2}&apos;,
        ///    START_DATE =&gt; SYSTIMESTAMP + INTERVAL &apos;{1}&apos; MINUTE,
        ///    END_DATE =&gt; NULL,
        ///    ENABLED =&gt; FALSE,
        ///    AUTO_DROP =&gt; TRUE);
        ///  
        ///  DBMS_SCHEDULER.SET_ATTRIBUTE(
        ///    NAME =&gt; &apos;JOB_{0}&apos;, 
        ///    ATTRIBUTE =&gt; &apos;restartable&apos;, 
        ///    VALUE =&gt; TRUE);
        ///END;.
        /// </summary>
        internal static string ScriptJobCreate {
            get {
                return ResourceManager.GetString("ScriptJobCreate", resourceCulture);
            }
        }
    }
}