using System;
using System.Collections.Generic;
using System.Text;

namespace SMSBackupToHtml
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class smses
    {

        private smsesSms[] smsField;

        private smsesMms[] mmsField;

        private ushort countField;

        private string backup_setField;

        private ulong backup_dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sms")]
        public smsesSms[] sms
        {
            get
            {
                return this.smsField;
            }
            set
            {
                this.smsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mms")]
        public smsesMms[] mms
        {
            get
            {
                return this.mmsField;
            }
            set
            {
                this.mmsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string backup_set
        {
            get
            {
                return this.backup_setField;
            }
            set
            {
                this.backup_setField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong backup_date
        {
            get
            {
                return this.backup_dateField;
            }
            set
            {
                this.backup_dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class smsesSms
    {

        private byte protocolField;

        private long addressField;

        private ulong dateField;

        private byte typeField;

        private string subjectField;

        private string bodyField;

        private string toaField;

        private string sc_toaField;

        private string service_centerField;

        private byte readField;

        private sbyte statusField;

        private byte lockedField;

        private ulong date_sentField;

        private sbyte sub_idField;

        private string readable_dateField;

        private string contact_nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toa
        {
            get
            {
                return this.toaField;
            }
            set
            {
                this.toaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sc_toa
        {
            get
            {
                return this.sc_toaField;
            }
            set
            {
                this.sc_toaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service_center
        {
            get
            {
                return this.service_centerField;
            }
            set
            {
                this.service_centerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte read
        {
            get
            {
                return this.readField;
            }
            set
            {
                this.readField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte locked
        {
            get
            {
                return this.lockedField;
            }
            set
            {
                this.lockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong date_sent
        {
            get
            {
                return this.date_sentField;
            }
            set
            {
                this.date_sentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte sub_id
        {
            get
            {
                return this.sub_idField;
            }
            set
            {
                this.sub_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string readable_date
        {
            get
            {
                return this.readable_dateField;
            }
            set
            {
                this.readable_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contact_name
        {
            get
            {
                return this.contact_nameField;
            }
            set
            {
                this.contact_nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class smsesMms
    {

        private smsesMmsPart[] partsField;

        private smsesMmsAddr[] addrsField;

        private ulong dateField;

        private byte spam_reportField;

        private string ct_tField;

        private byte msg_boxField;

        private long addressField;

        private string sub_csField;

        private string retr_stField;

        private string d_tmField;

        private string expField;

        private byte lockedField;

        private byte msg_idField;

        private byte app_idField;

        private string from_addressField;

        private string m_idField;

        private string retr_txtField;

        private uint date_sentField;

        private byte readField;

        private string rpt_aField;

        private string ct_clsField;

        private string priField;

        private sbyte sub_idField;

        private string object_idField;

        private string resp_txtField;

        private string ct_lField;

        private byte d_rptField;

        private byte reservedField;

        private byte using_modeField;

        private byte rr_stField;

        private byte m_typeField;

        private byte favoriteField;

        private byte rrField;

        private string subField;

        private byte hiddenField;

        private byte deletableField;

        private string read_statusField;

        private byte d_rpt_stField;

        private byte callback_setField;

        private byte seenField;

        private string device_nameField;

        private string cmc_propField;

        private string resp_stField;

        private byte text_onlyField;

        private byte sim_slotField;

        private string stField;

        private string retr_txt_csField;

        private string creatorField;

        private uint m_sizeField;

        private string sim_imsiField;

        private string correlation_tagField;

        private byte safe_messageField;

        private string tr_idField;

        private string m_clsField;

        private string vField;

        private byte secret_modeField;

        private string readable_dateField;

        private string contact_nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("part", IsNullable = false)]
        public smsesMmsPart[] parts
        {
            get
            {
                return this.partsField;
            }
            set
            {
                this.partsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("addr", IsNullable = false)]
        public smsesMmsAddr[] addrs
        {
            get
            {
                return this.addrsField;
            }
            set
            {
                this.addrsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte spam_report
        {
            get
            {
                return this.spam_reportField;
            }
            set
            {
                this.spam_reportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct_t
        {
            get
            {
                return this.ct_tField;
            }
            set
            {
                this.ct_tField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte msg_box
        {
            get
            {
                return this.msg_boxField;
            }
            set
            {
                this.msg_boxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sub_cs
        {
            get
            {
                return this.sub_csField;
            }
            set
            {
                this.sub_csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retr_st
        {
            get
            {
                return this.retr_stField;
            }
            set
            {
                this.retr_stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string d_tm
        {
            get
            {
                return this.d_tmField;
            }
            set
            {
                this.d_tmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exp
        {
            get
            {
                return this.expField;
            }
            set
            {
                this.expField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte locked
        {
            get
            {
                return this.lockedField;
            }
            set
            {
                this.lockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte msg_id
        {
            get
            {
                return this.msg_idField;
            }
            set
            {
                this.msg_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte app_id
        {
            get
            {
                return this.app_idField;
            }
            set
            {
                this.app_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string from_address
        {
            get
            {
                return this.from_addressField;
            }
            set
            {
                this.from_addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string m_id
        {
            get
            {
                return this.m_idField;
            }
            set
            {
                this.m_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retr_txt
        {
            get
            {
                return this.retr_txtField;
            }
            set
            {
                this.retr_txtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date_sent
        {
            get
            {
                return this.date_sentField;
            }
            set
            {
                this.date_sentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte read
        {
            get
            {
                return this.readField;
            }
            set
            {
                this.readField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rpt_a
        {
            get
            {
                return this.rpt_aField;
            }
            set
            {
                this.rpt_aField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct_cls
        {
            get
            {
                return this.ct_clsField;
            }
            set
            {
                this.ct_clsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pri
        {
            get
            {
                return this.priField;
            }
            set
            {
                this.priField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte sub_id
        {
            get
            {
                return this.sub_idField;
            }
            set
            {
                this.sub_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string object_id
        {
            get
            {
                return this.object_idField;
            }
            set
            {
                this.object_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resp_txt
        {
            get
            {
                return this.resp_txtField;
            }
            set
            {
                this.resp_txtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct_l
        {
            get
            {
                return this.ct_lField;
            }
            set
            {
                this.ct_lField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte d_rpt
        {
            get
            {
                return this.d_rptField;
            }
            set
            {
                this.d_rptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte reserved
        {
            get
            {
                return this.reservedField;
            }
            set
            {
                this.reservedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte using_mode
        {
            get
            {
                return this.using_modeField;
            }
            set
            {
                this.using_modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rr_st
        {
            get
            {
                return this.rr_stField;
            }
            set
            {
                this.rr_stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte m_type
        {
            get
            {
                return this.m_typeField;
            }
            set
            {
                this.m_typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte favorite
        {
            get
            {
                return this.favoriteField;
            }
            set
            {
                this.favoriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rr
        {
            get
            {
                return this.rrField;
            }
            set
            {
                this.rrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sub
        {
            get
            {
                return this.subField;
            }
            set
            {
                this.subField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte deletable
        {
            get
            {
                return this.deletableField;
            }
            set
            {
                this.deletableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string read_status
        {
            get
            {
                return this.read_statusField;
            }
            set
            {
                this.read_statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte d_rpt_st
        {
            get
            {
                return this.d_rpt_stField;
            }
            set
            {
                this.d_rpt_stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte callback_set
        {
            get
            {
                return this.callback_setField;
            }
            set
            {
                this.callback_setField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte seen
        {
            get
            {
                return this.seenField;
            }
            set
            {
                this.seenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string device_name
        {
            get
            {
                return this.device_nameField;
            }
            set
            {
                this.device_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cmc_prop
        {
            get
            {
                return this.cmc_propField;
            }
            set
            {
                this.cmc_propField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resp_st
        {
            get
            {
                return this.resp_stField;
            }
            set
            {
                this.resp_stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte text_only
        {
            get
            {
                return this.text_onlyField;
            }
            set
            {
                this.text_onlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sim_slot
        {
            get
            {
                return this.sim_slotField;
            }
            set
            {
                this.sim_slotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string retr_txt_cs
        {
            get
            {
                return this.retr_txt_csField;
            }
            set
            {
                this.retr_txt_csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint m_size
        {
            get
            {
                return this.m_sizeField;
            }
            set
            {
                this.m_sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sim_imsi
        {
            get
            {
                return this.sim_imsiField;
            }
            set
            {
                this.sim_imsiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string correlation_tag
        {
            get
            {
                return this.correlation_tagField;
            }
            set
            {
                this.correlation_tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte safe_message
        {
            get
            {
                return this.safe_messageField;
            }
            set
            {
                this.safe_messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tr_id
        {
            get
            {
                return this.tr_idField;
            }
            set
            {
                this.tr_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string m_cls
        {
            get
            {
                return this.m_clsField;
            }
            set
            {
                this.m_clsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte secret_mode
        {
            get
            {
                return this.secret_modeField;
            }
            set
            {
                this.secret_modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string readable_date
        {
            get
            {
                return this.readable_dateField;
            }
            set
            {
                this.readable_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contact_name
        {
            get
            {
                return this.contact_nameField;
            }
            set
            {
                this.contact_nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class smsesMmsPart
    {

        private sbyte seqField;

        private string ctField;

        private string nameField;

        private string chsetField;

        private string cdField;

        private string fnField;

        private string cidField;

        private string clField;

        private string ctt_sField;

        private string ctt_tField;

        private string textField;

        private byte sef_typeField;

        private string dataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte seq
        {
            get
            {
                return this.seqField;
            }
            set
            {
                this.seqField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ct
        {
            get
            {
                return this.ctField;
            }
            set
            {
                this.ctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chset
        {
            get
            {
                return this.chsetField;
            }
            set
            {
                this.chsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fn
        {
            get
            {
                return this.fnField;
            }
            set
            {
                this.fnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cid
        {
            get
            {
                return this.cidField;
            }
            set
            {
                this.cidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cl
        {
            get
            {
                return this.clField;
            }
            set
            {
                this.clField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ctt_s
        {
            get
            {
                return this.ctt_sField;
            }
            set
            {
                this.ctt_sField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ctt_t
        {
            get
            {
                return this.ctt_tField;
            }
            set
            {
                this.ctt_tField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sef_type
        {
            get
            {
                return this.sef_typeField;
            }
            set
            {
                this.sef_typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class smsesMmsAddr
    {

        private long addressField;

        private byte typeField;

        private byte charsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }
    }


}
