using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System;
using longhu.his.Model;

namespace longhu.his.Common
{
    /// <summary>
    /// 静态工具类
    /// </summary>
    public sealed class Utilities
    {
        private static readonly string[] SensitiveString = { "select", "1=1", "and", "where" };
        public static string MD5Encrypt(string sourceString)
        {
            var md5 = MD5.Create();
            byte[] bytes = Encoding.Default.GetBytes(sourceString);
            byte[] encryptStr = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptStr.Length; i++)
            {
                sb.Append(encryptStr[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public static bool VerifyUserStringEnter(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                MessageBox.Show("您的输入不能为空！", "提示", MessageBoxButtons.OK);
                return false;
            }
            else if (IsContains(source))
            {
                MessageBox.Show("您的输入包含非法字符，请重新输入！", "提示", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsContains(string source)
        {
            bool result = false;
            foreach (string s in SensitiveString)
            {
                if (source.Contains(s))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }



        /// <summary>
        /// 分析药品批号 计算药品有效期
        /// 
        /// 药品有效期默认是 2年
        /// </summary>
        /// <param name="batchNumber"></param>
        /// <returns></returns>
        public static DateTime? HandleDgBatchNumber(string batchNumber)
        {
            return null;
        }

        public static void bindPropertiesToCtl(DrugEntryModel drugEntry, Form frm)
        {
            if (drugEntry == null)
            {
                MessageBox.Show("打开入库单操作失败，请稍后重试！", "出错啦", MessageBoxButtons.OK);
                return;
            }

            foreach (var ctl in frm.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctl).ReadOnly = true;
                }
                else if (ctl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctl).Enabled = false;
                }
                else if (ctl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctl).Enabled = false;
                }
                else if (ctl.GetType() == typeof(Button))
                {
                    ((Button)ctl).Enabled = false;
                }
                else if (ctl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)ctl).Enabled = false;
                }
                else
                {

                }

                switch (ctl.GetType().Name)
                {
                    case "TextBox":
                        switch (((TextBox)ctl).Name)
                        {
                            case "textSupplier":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.drug_supplier.supplier_name;
                                break;
                            // 入库单号
                            case "textGodownEntryNo":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.purchase_note_id;
                                break;
                            // 发票号码
                            case "textInvoiceCode":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.billNumer;
                                break;
                            // 药品字典编码
                            case "textDrugCode":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.dg_codes;
                                break;
                            case "textDrugSpecification":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.drug_specification.Specification_name;
                                break;
                            case "textProduceArea":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.dg_ProduceArea;
                                break;
                            // 上次进价
                            case "textLastPurchasePrice":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.dg_last_price.ToString();
                                break;
                            case "textPackingCompany":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.drug_Packer;
                                break;
                            // 售价
                            case "textSalesPrice":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.dg_sales_price.ToString();
                                break;
                            // 批发价
                            case "textWholeSalePrice":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.dg_whole_price.ToString();
                                break;
                            // 数量
                            case "textAmount":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.Amount.ToString();
                                break;
                            case "textPurchasePriceAmout":
                                var total = drugEntry.GodownEntry.GodownEntryDetails.Amount * drugEntry.GodownEntry.GodownEntryDetails.dg_price;
                                ((TextBox)ctl).Text = drugEntry.ToString();
                                break;
                            //采购价格
                            case "textPurchasePrice":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.dg_price.ToString();
                                break;
                            // 药品批号
                            case "textDrugBatchNumber":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.Drug_batch_number;
                                break;
                            // 默认折扣
                            case "textDefaultDiscount":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.Default_discount_rate.ToString();
                                break;
                            // 药品折扣
                            case "textPurchaseDiscount":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.Dicount_rate.ToString();
                                break;
                            case "textRemark":
                                ((TextBox)ctl).Text = drugEntry.GodownEntry.GodownEntryDetails.remark;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "ComboBox":
                        switch (((ComboBox)ctl).Name)
                        {
                            case "cmbEntryType":
                                if (drugEntry.GodownEntry.drug_entryType_id > 0)
                                    ((ComboBox)ctl).SelectedIndex = ((ComboBox)ctl).Items.IndexOf(drugEntry.GodownEntry.drug_entryType_id);
                                break;
                            case "cmbxDgSpecific":
                                if (drugEntry.GodownEntry.GodownEntryDetails.dg_specification_id > 0)
                                    ((ComboBox)ctl).SelectedIndex = ((ComboBox)ctl).Items.IndexOf(drugEntry.GodownEntry.GodownEntryDetails.dg_specification_id);

                                break;
                            case "cmbxDgUnits":
                                if (drugEntry.GodownEntry.GodownEntryDetails.dg_units_id > 0)
                                    ((ComboBox)ctl).SelectedIndex = ((ComboBox)ctl).Items.IndexOf(drugEntry.GodownEntry.GodownEntryDetails.dg_units_id);

                                break;
                            case "cmbxDgCategory":
                                if (drugEntry.GodownEntry.GodownEntryDetails.dg_Category_id > 0)
                                    ((ComboBox)ctl).SelectedIndex = ((ComboBox)ctl).Items.IndexOf(drugEntry.GodownEntry.GodownEntryDetails.dg_Category_id);

                                break;
                            default:
                                break;
                        }

                        break;
                    case "DateTimePicker":
                        switch (((DateTimePicker)ctl).Name)
                        {
                            case "dtp_Entry_date":
                                ((DateTimePicker)ctl).Value = drugEntry.GodownEntry.Created_date ?? DateTime.MinValue;
                                break;
                            case "dtp_Bill_note":
                                ((DateTimePicker)ctl).Value = drugEntry.GodownEntry.bill_date ?? DateTime.MinValue;
                                break;
                            case "dtpExpirationDate":
                                ((DateTimePicker)ctl).Value = drugEntry.GodownEntry.GodownEntryDetails.dg_expiration_date ?? DateTime.MinValue;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "CheckBox":
                        switch (((CheckBox)ctl).Name)
                        {
                            case "checkNedChgDiscount":
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

            }

        }

        #region 获取汉字拼音首字母

        /// <summary>
        /// 在指定的字符串列表CnStr中检索符合拼音索引字符串
        /// </summary>
        /// <param name="CnStr">汉字字符串</param>
        /// <returns>相对应的汉语拼音首字母串</returns>
        public static string GetSpellCode(string CnStr)
        {
            string strTemp = "";
            int iLen = CnStr.Length;
            int i = 0;

            for (i = 0; i <= iLen - 1; i++)
            {
                strTemp += GetCharSpellCode(CnStr.Substring(i, 1));
            }
            return strTemp;
        }

        /// <summary>
        /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母
        /// </summary>
        /// <param name="CnChar">单个汉字</param>
        /// <returns>单个大写字母</returns>
        private static string GetCharSpellCode(string CnChar)
        {
            long iCnChar;
            byte[] ZW = System.Text.Encoding.Default.GetBytes(CnChar);

            //如果是字母，则直接返回
            if (ZW.Length == 1)
            {
                return CnChar.ToUpper();
            }
            else
            {
                // get the array of byte from the single char
                int i1 = (short)(ZW[0]);
                int i2 = (short)(ZW[1]);
                iCnChar = i1 * 256 + i2;
            }
            // iCnChar match the constant
            if ((iCnChar >= 45217) && (iCnChar <= 45252))
            {
                return "A";
            }
            else if ((iCnChar >= 45253) && (iCnChar <= 45760))
            {
                return "B";
            }
            else if ((iCnChar >= 45761) && (iCnChar <= 46317))
            {
                return "C";
            }
            else if ((iCnChar >= 46318) && (iCnChar <= 46825))
            {
                return "D";
            }
            else if ((iCnChar >= 46826) && (iCnChar <= 47009))
            {
                return "E";
            }
            else if ((iCnChar >= 47010) && (iCnChar <= 47296))
            {
                return "F";
            }
            else if ((iCnChar >= 47297) && (iCnChar <= 47613))
            {
                return "G";
            }
            else if ((iCnChar >= 47614) && (iCnChar <= 48118))
            {
                return "H";
            }
            else if ((iCnChar >= 48119) && (iCnChar <= 49061))
            {
                return "J";
            }
            else if ((iCnChar >= 49062) && (iCnChar <= 49323))
            {
                return "K";
            }
            else if ((iCnChar >= 49324) && (iCnChar <= 49895))
            {
                return "L";
            }
            else if ((iCnChar >= 49896) && (iCnChar <= 50370))
            {
                return "M";
            }
            else if ((iCnChar >= 50371) && (iCnChar <= 50613))
            {
                return "N";
            }
            else if ((iCnChar >= 50614) && (iCnChar <= 50621))
            {
                return "O";
            }
            else if ((iCnChar >= 50622) && (iCnChar <= 50905))
            {
                return "P";
            }
            else if ((iCnChar >= 50906) && (iCnChar <= 51386))
            {
                return "Q";
            }
            else if ((iCnChar >= 51387) && (iCnChar <= 51445))
            {
                return "R";
            }
            else if ((iCnChar >= 51446) && (iCnChar <= 52217))
            {
                return "S";
            }
            else if ((iCnChar >= 52218) && (iCnChar <= 52697))
            {
                return "T";
            }
            else if ((iCnChar >= 52698) && (iCnChar <= 52979))
            {
                return "W";
            }
            else if ((iCnChar >= 52980) && (iCnChar <= 53640))
            {
                return "X";
            }
            else if ((iCnChar >= 53689) && (iCnChar <= 54480))
            {
                return "Y";
            }
            else if ((iCnChar >= 54481) && (iCnChar <= 55289))
            {
                return "Z";
            }
            else
                return ("?");
        }

        #endregion


        public static decimal CalculateChargeBack(decimal pay, decimal realPay)
        {
            decimal chargeBack = 0;
            if (realPay >= pay)
            {
                chargeBack = realPay - pay;
            }
            else
            {

            }
            return chargeBack;
        }
    }
}
