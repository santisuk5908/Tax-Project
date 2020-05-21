using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX
{
    public partial class index : Form
    {
        string name = ""; //ชื่อผู้ใช้
        double income = 0; //รายได้ต่อปี  //อย่าลืม ลดทันที 60,000 บาท
        int myself = 60000; //ลดหย่อนตนเอง


        //ตนเอง และครอบครัว
        int Spouse = 0; //เก็บค่าลดหย่อนคู่สมรส
        int son_30000 = 0;
        int son_60000 = 0;
        int sum_son = 0; //รวมค่าลดหย่อนลูก
        int father_User = 0; //พ่อแม่ของผู้ใช้
        int mother_User = 0;
        int father_Spouse = 0; //พ่อแม่ของคู่สมรส
        int mother_Spouse = 0;
        int sum_FatherAndMother = 0; //รวมของบิดามารดา
        int womb = 0; //ค่าตั้งครรภ์
        int cripple = 0;//คนพิการ


        //ประกันเงินออม และการลงทุน
        int social_security = 0; //ประกันสังคม
        int life_security = 0; //ประกันชีวิต
        int heal_security = 0; //ประกันสุขภาพ
        int spouse_security = 0; //ประกันคู่สมรส
        int FM_security = 0; //ประกันบิดามารดา
        int provident_fund = 0; //กองทุนสำรองเลี้ยงชีพ
        int KOH = 0; //กอช.
        int teacher_fund = 0; //กองทุนครู
        int pension = 0; //เบี้ยบำนาญ
        int LTF = 0;
        int RMF = 0;


        //อสังหาริมทรัพย์
        int interestHome_value = 0; //ดอกเบี้ยบ้าน
        int buyHomefrist_value = 0; //โครงการบ้านหลังแรก


        //เงินบริจาค
        int donate_to_the_state = 0; //บริจาคให้สาธารณประโยชน์
        int pabuk = 0; //ปาบึก
        int normal_donate = 0; //บริจาคทั่วไป
        int donate_to_political = 0; //ให้พรรคการเมือง

        //กระตุ้นเศรษฐกิจ
        int shop_help_nation = 0; //ช้อปช่วยชาติ
        int shop_sport = 0; //ซื้อของกีฬา
        int shop_book = 0; //หนังสือ
        int repair_home_frompabuk = 0; //ซ่อมบ้านจากปาบึก
        int repair_home_frompodul = 0; //ซ่อมบบ้านจากโพดุล
        int shop_OTOP = 0;
        int travel_main = 0;
        int travel_seconary = 0;
        int repair_car = 0;
        int realty = 0;

        //อื่นๆ 
        double net = 0;
        double vat = 0;
        float sum_tax = 0; //รวมส่วนลดหย่อน
        double allpay = 0;
        string allpay_string = "";
        int group1 = 0;
        int group2 = 0;
        int group3 = 0;
        int group4 = 0;
        int group5 = 0;


        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void HomeBT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 268);
            workBar.Size = new Size(8, 60);
            Panelindex.BringToFront();
            
        }

        private void Group1BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 327);
            workBar.Size = new Size(8, 60);
            Panel_Group1.BringToFront();
        }

        private void Group2BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 386);
            workBar.Size = new Size(8, 77);
            Panel_group2.BringToFront();
        }

        private void Group3BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 462);
            workBar.Size = new Size(8, 60);
            Panel_group3.BringToFront();
        }

        private void Group4BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 521);
            workBar.Size = new Size(8, 60);
            Panel_group4.BringToFront();
        }

        private void Group5BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 580);
            workBar.Size = new Size(8, 60);
            Panel_group5.BringToFront();
        }

        private void Panelindex_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Next_to_family_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 327);
            workBar.Size = new Size(8, 60);
            Panel_Group1.BringToFront();
        }

        //ตนเองและครอบครัว---------------------------------------------------------------------------------------------------------------------
        private void status_user_SelectedIndexChanged(object sender, EventArgs e) //เมื่อมีการแก้ไขค่า สถานภาพ
        {
            if (status_user.Text == "มีคู่สมรส แต่คู่สมรสไม่มีรายได้")
            {
                Spouse = 60000;
            }
            else
            {
                Spouse = 0;
            }
        }

        private void No_son_CheckedChanged(object sender, EventArgs e) //ถ้าไม่มีลูก
        {
            if (No_son.Checked == true)
            {
                son_before2561.Checked = false;
                son_before2561.Enabled = false;

                son_after2561.Checked = false;
                son_after2561.Enabled = false;

                son_before2561_Numberlic.Text = "0";
                son_before2561_Numberlic.Enabled = false;

                son_after2561_Numberlic.Text = "0";
                son_after2561_Numberlic.Enabled = false;
                sum_son = 0;
            }
        }

        private void Have_son_CheckedChanged(object sender, EventArgs e)//เมื่อมีลูก
        {
            if (Have_son.Checked == true)
            {
                son_before2561.Checked = false;
                son_before2561.Enabled = true;

                son_after2561.Checked = false;
                son_after2561.Enabled = true;

                son_before2561_Numberlic.Text = "0";
                son_before2561_Numberlic.Enabled = false;

                son_after2561_Numberlic.Text = "0";
                son_after2561_Numberlic.Enabled = false;
                sum_son = 0;
            }
        }

        private void son_before2561_CheckedChanged(object sender, EventArgs e)
        {
            if (son_before2561.Checked == true)
            {
                son_before2561_Numberlic.Enabled = true;
            }
            else
            {
                son_before2561_Numberlic.Text = "0";
                son_before2561_Numberlic.Enabled = false;
            }
        }

        private void son_after2561_CheckedChanged(object sender, EventArgs e)
        {
            if (son_after2561.Checked == true)
            {
                son_after2561_Numberlic.Enabled = true;
            }
            else
            {
                son_after2561_Numberlic.Text = "0";
                son_after2561_Numberlic.Enabled = false;
            }
        }

        private void father_userTB_CheckedChanged(object sender, EventArgs e) //การตรวจสอบข้อมูล การลดหย่อนพ่อแม่
        {
            if (father_userTB.Checked == true)
            {
                father_User = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                father_User = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void mother_userTB_CheckedChanged(object sender, EventArgs e)
        {
            if (mother_userTB.Checked == true)
            {
                mother_User = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                mother_User = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void father_SpouseTB_CheckedChanged(object sender, EventArgs e)
        {
            if (father_SpouseTB.Checked == true)
            {
                father_Spouse = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                father_Spouse = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void mother_SpouseTB_CheckedChanged(object sender, EventArgs e)
        {
            if (mother_SpouseTB.Checked == true)
            {
                mother_Spouse = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                mother_Spouse = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void womb_textbox_ValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(womb_textbox.Text) > 60000)
            {
                womb = 60000;
            }
            else
            {
                womb = int.Parse(womb_textbox.Text);
            }
        }

        private void cripple_textbox_ValueChanged(object sender, EventArgs e)
        {
            cripple = int.Parse(cripple_textbox.Text) * 60000;
        }

        private void Back_to_index_Click(object sender, EventArgs e) //เมื่อกดปุ่มกลับในหน้า ตนเองและครอบครัว
        {
            workBar.Location = new Point(0, 268);
            workBar.Size = new Size(8, 60);
            Panelindex.BringToFront();
        }

        private void Next_to_Group2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ลดหย่อนตนเอง  "+ myself +"  บาท"+ "\nลดหย่อนคู่สมรส  " + Spouse.ToString() +"  บาท"+ "\nลดหย่อนค่าบุตร  " + sum_son.ToString() + "  บาท" + "\nลดหย่อนบุพการี  " + sum_FatherAndMother.ToString() + "  บาท" + "\nลดหย่อนการตั้งครรภ์  " + womb.ToString() + "  บาท" + "\nลดหย่อนอุปการะคนพิการ  " + cripple.ToString() + "  บาท", "สรุปการลดหย่อนภาษี กลุ่มตนเอง และครอบครัว");
            workBar.Location = new Point(0, 386);
            workBar.Size = new Size(8, 77);
            Panel_group2.BringToFront();
        }

        private void son_before2561_Numberlic_ValueChanged(object sender, EventArgs e) //เมื่อเกิดการแก้ไขช่องที่ลุก เกิดก่อน 2561
        {
            son_30000 = int.Parse(son_before2561_Numberlic.Text);
            sum_son = (son_30000 * 30000) + (son_60000 * 60000);
        }

        private void son_after2561_Numberlic_ValueChanged(object sender, EventArgs e) //เมื่อเกิดการแก้ไขช่องที่ลุก เกิดหลัง 2561
        {
            son_60000 = int.Parse(son_after2561_Numberlic.Text);
            sum_son = (son_30000 * 30000) + (son_60000 * 60000);
        }

        private void index_name_TextChanged(object sender, EventArgs e) //เก็บค่าชื่อผู้ใช้ ในหน้าหลัก
        {
            name = index_name.Text;
        }

        private void index_income_ValueChanged(object sender, EventArgs e)//เก็บค่ารายได้ (income) ในหน้าหลัก
        {
            income = Convert.ToDouble(index_income.Text);
        }


        //กลุ่มประกัน เงินออมและการลงทุน --------------------------------------------------------------------------------------------------------------------
        private void social_secTB_ValueChanged(object sender, EventArgs e)
        {
            social_security = int.Parse(social_secTB.Text);
        }

        private void life_sec_ValueChanged(object sender, EventArgs e)
        {
            life_security = int.Parse(life_sec.Text);
            if (life_security + heal_security > 100000)
            {
                MessageBox.Show("เมื่อประกันสุขภาพรวมกับประกันชีวิตแล้วจะต้องไม่เกิน 100,000 บาท");
                life_sec.Text = "0";
                life_security = 0;
            }
        }

        private void heal_sec_ValueChanged(object sender, EventArgs e)
        {
            heal_security = int.Parse(heal_sec.Text);
            if (life_security + heal_security > 100000)
            {
                MessageBox.Show("เมื่อประกันสุขภาพรวมกับประกันชีวิตแล้วจะต้องไม่เกิน 100,000 บาท");
                heal_sec.Text = "0";
                heal_security = 0;
            }
        }

        private void spouse_sec_ValueChanged(object sender, EventArgs e)
        {
            spouse_security = int.Parse(spouse_sec.Text);
        }

        private void FM_sec_ValueChanged(object sender, EventArgs e)
        {
            FM_security = int.Parse(FM_sec.Text);
        }

        private void provident_fundTB_ValueChanged(object sender, EventArgs e)
        {
            provident_fund = int.Parse(provident_fundTB.Text);
        }

        private void teacher_fundTB_ValueChanged(object sender, EventArgs e)
        {
            teacher_fund = int.Parse(teacher_fundTB.Text);
        }

        private void KOH_TB_ValueChanged(object sender, EventArgs e)
        {
            KOH = int.Parse(KOH_TB.Text);
        }

        private void pension_TB_ValueChanged(object sender, EventArgs e)
        {
            pension = int.Parse(pension_TB.Text);
        }

        private void LTF_TB_ValueChanged(object sender, EventArgs e)
        {
            LTF = int.Parse(LTF_TB.Text);
        }

        private void RMF_TB_ValueChanged(object sender, EventArgs e)
        {
            RMF = int.Parse(RMF_TB.Text);
        }

        private void back_to_group1_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 327);
            workBar.Size = new Size(8, 60);
            Panel_Group1.BringToFront();
        }

        private void next_to_group3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ประกันสังคม  " + social_security.ToString() + "  บาท"+ "\nประกันชีวิต  " + life_security.ToString() + "  บาท" + "\nประกันสุขภาพ  " + heal_security.ToString() + "  บาท" + "\nประกันคู่สมรส  " + spouse_security.ToString() + "  บาท" + "\nประกันบิดามารดา  " + FM_security.ToString() + "  บาท" + "\nกองทุนสำรองเลี้ยงชีพ  " + provident_fund.ToString() + "  บาท" + "\nกอช.  " + KOH.ToString() + "  บาท" + "\nกองทุนครู  " + teacher_fund.ToString() + "  บาท" + "\nเบี้ยบำนาญ  " + pension.ToString() + "  บาท" + "\nLTF  " + LTF.ToString() + "  บาท" + "\nRMF  " + RMF.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 462);
            workBar.Size = new Size(8, 60);
            Panel_group3.BringToFront();
        }


        //กลุ่มอสังหาริมทรัพย์ --------------------------------------------------------------------------------------------------------------------
        private void buyHome2558_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (buyHome2558_Check.Checked == true)
            {
                buyHome2558.Enabled = true;

                buyHome2562.Enabled = false;
                buyHome2562.Text = "0";
            }
        }

        private void buyHome2562_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (buyHome2562_Check.Checked == true)
            {
                buyHome2562.Enabled = true;

                buyHome2558.Enabled = false;
                buyHome2558.Text = "0";
            }
        }

        private void buyHome2558_ValueChanged(object sender, EventArgs e)
        {
            buyHomefrist_value = int.Parse(buyHome2558.Text);
        }

        private void buyHome_TB_ValueChanged(object sender, EventArgs e)
        {
            interestHome_value = int.Parse(buyHome_TB.Text);
        }

        private void buyHome2562_ValueChanged(object sender, EventArgs e)
        {
            buyHomefrist_value = int.Parse(buyHome2562.Text);
        }

        private void back_to_group2_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 386);
            workBar.Size = new Size(8, 77);
            Panel_group2.BringToFront();
        }

        //กลุ่มเงินบริจาค --------------------------------------------------------------------------------------------------------------------
        private void back_to_group3_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 462);
            workBar.Size = new Size(8, 60);
            Panel_group3.BringToFront();
        }

        private void next_to_group5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("บริจาคให้สาธารณประโยชน์  " + donate_to_the_state.ToString() + "  บาท" + "\nบริจาคอุทกภัยน้ำท่วมจากพายุปาบึก  " + pabuk.ToString() + "  บาท"+ "\nบริจาคทั่วไป  " + normal_donate.ToString() + "  บาท" + "\nบริจาคให้พรรคการเมือง  " + donate_to_political.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 580);
            workBar.Size = new Size(8, 60);
            Panel_group5.BringToFront();
        }

        private void donate_to_the_state_TB_ValueChanged(object sender, EventArgs e)
        {
            donate_to_the_state = int.Parse(donate_to_the_state_TB.Text) * 2;
        }

        private void pabuk_TB_ValueChanged(object sender, EventArgs e)
        {
            pabuk = int.Parse(pabuk_TB.Text);
        }

        private void normal_donate_TB_ValueChanged(object sender, EventArgs e)
        {
            normal_donate = int.Parse(normal_donate_TB.Text);
        }

        private void donate_to_political_TB_ValueChanged(object sender, EventArgs e)
        {
            donate_to_political = int.Parse(donate_to_political_TB.Text);
        }

        private void next_to_group4_Click(object sender, EventArgs e) //เมื่อกดปุ่ม ไปหน้าบริจาค
        {
            MessageBox.Show("ดอกเบี้ยบ้าน  " + interestHome_value.ToString() + "  บาท" + "\nโครงการบ้านหลังแรก  " + buyHomefrist_value.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 521);
            workBar.Size = new Size(8, 60);
            Panel_group4.BringToFront();
        }


        //กลุ่มกระตุ้นเศรษฐกิจ --------------------------------------------------------------------------------------------------------------------

        private void shop_help_nation_TB_ValueChanged_1(object sender, EventArgs e)
        {
            shop_help_nation = int.Parse(shop_help_nation_TB.Text);
        }

        private void shop_sport_TB_ValueChanged(object sender, EventArgs e)
        {
            shop_sport = int.Parse(shop_sport_TB.Text);
        }

        private void shop_book_TB_ValueChanged(object sender, EventArgs e)
        {
            shop_book = int.Parse(shop_book_TB.Text);
        }

        private void repair_home_frompabuk_TB_ValueChanged(object sender, EventArgs e)
        {
            repair_home_frompabuk = int.Parse(repair_home_frompabuk_TB.Text);
        }

        private void shop_OTOP_TB_ValueChanged(object sender, EventArgs e)
        {
            shop_OTOP = int.Parse(shop_OTOP_TB.Text);
        }

        private void repair_home_frompodul_TB_ValueChanged(object sender, EventArgs e)
        {
            repair_home_frompodul = int.Parse(repair_home_frompodul_TB.Text);
        }

        private void travel_main_TB_ValueChanged(object sender, EventArgs e)
        {
            travel_main = int.Parse(travel_main_TB.Text);
        }

        private void travel_seconary_TB_ValueChanged(object sender, EventArgs e)
        {
            travel_seconary = int.Parse(travel_seconary_TB.Text);
        }

        private void repair_car_TB_ValueChanged(object sender, EventArgs e)
        {
            repair_car = int.Parse(repair_car_TB.Text);
        }

        private void realty_TB_ValueChanged(object sender, EventArgs e)
        {
            realty = int.Parse(realty_TB.Text);
        }

        private void concept_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 679);
            workBar.Size = new Size(8, 60);
            Tax_calculation();
            Panel_view.BringToFront();
            income_TB.Text = income.ToString();
            sumtax_TB.Text = sum_tax.ToString();
            net_TB.Text = net.ToString();
            vat_TB.Text = string.Format("{0} %", vat * 100);
            allpay_string_TB.Text = allpay_string;
            
            Tax_calculation();
            income_TB.Text = income.ToString();
            sumtax_TB.Text = sum_tax.ToString();
            net_TB.Text = net.ToString();
            vat_TB.Text = string.Format("{0} %", vat * 100);
            allpay_string_TB.Text = allpay_string;
        }

        private void Tax_calculation()
        {
            try
            {
                group1 = myself + Spouse + sum_son + sum_FatherAndMother + womb + cripple;
                group2 = social_security + life_security + heal_security + spouse_security + FM_security + provident_fund + KOH + teacher_fund + pension + LTF + RMF;
                group3 = interestHome_value + buyHomefrist_value;
                group4 = donate_to_the_state + pabuk + normal_donate + donate_to_political;
                group5 = shop_help_nation + shop_sport + shop_book + repair_home_frompabuk + repair_home_frompodul + shop_OTOP + travel_main + travel_seconary + repair_car + realty;
                
                sum_tax = group1 + group2 + group3 + group4 + group5;
                net = income - sum_tax;
                //MessageBox.Show(income.ToString(), "");
                if (net <= 150000)
                {
                    allpay = 0;
                    allpay_string = "ไม่ต้องเสียภาษี";
                }
                else if (net > 150000 && net <= 300000)
                {
                    vat = 0.05;
                    allpay = ((net-150000) * vat) + 0;
                    allpay_string = allpay.ToString();
                }
                else if (net > 30000 && net <= 500000)
                {
                    vat = 0.1;
                    allpay = ((net - 300000) * vat) + 7500;
                    allpay_string = allpay.ToString();
                }
                else if (net > 500000 && net <= 750000)
                {
                    vat = 0.15;
                    allpay = ((net - 500000) * vat) + 27500;
                    allpay_string = allpay.ToString();
                }
                else if (net > 750000 && net <= 1000000)
                {
                    vat = 0.2;
                    allpay = ((net - 750000) * vat) + 65000;
                    allpay_string = allpay.ToString();
                }
                else if (net > 1000000 && net <= 2000000)
                {
                    vat = 0.25;
                    allpay = ((net - 1000000) * vat) + 115000;
                    allpay_string = allpay.ToString();
                }
                else if (net > 2000000 && net <= 5000000)
                {
                    vat = 0.30;
                    allpay = ((net - 2000000) * vat) + 365000;
                    allpay_string = allpay.ToString();
                }
                else if (net > 5000000)
                {
                    vat = 0.35;
                    allpay = ((net - 5000000) * vat) + 1265000;
                    allpay_string = allpay.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดขึ้นผิดพลาด กรุณาตรวจสอบข้อมูล" + ex, "การแจ้งเตือน");
            }
        }

        private void next_to_concept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ช้อปช่วยชาติ  " + shop_help_nation.ToString() + "  บาท" + "\nซื้อของกีฬา  " + shop_sport.ToString() + "  บาท" + "\nซื้อหนังสือ  " + shop_book.ToString() + "  บาท" + "\nซ่อมบ้านจากพายุปาบึก  " + repair_home_frompabuk.ToString() + "  บาท" + "\nซ่อมบบ้านจากพายุโพดุล  " + repair_home_frompodul.ToString() + "  บาท" + "\nซื้อสินค้า OTOP  " + shop_OTOP.ToString() + "  บาท" + "\nเที่ยวเมืองหลัก  " + travel_main.ToString() + "  บาท" + "\nเที่ยวเมืองรอง  " + travel_seconary.ToString() + "  บาท" + "\nค่าซ่อมรถ  " + repair_car.ToString() + "  บาท" + "\nอสังหาริมทรัพย์และรถ  " + realty.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 679);
            workBar.Size = new Size(8, 60);
            Tax_calculation();
            Panel_view.BringToFront();
            income_TB.Text = income.ToString();
            sumtax_TB.Text = sum_tax.ToString();
            net_TB.Text = net.ToString();
            vat_TB.Text = string.Format("{0} %", vat * 100);
            allpay_string_TB.Text = allpay_string;

            Tax_calculation();
            income_TB.Text = income.ToString();
            sumtax_TB.Text = sum_tax.ToString();
            net_TB.Text = net.ToString();
            vat_TB.Text = string.Format("{0} %", vat * 100);
            allpay_string_TB.Text = allpay_string;
        }
    }
}
