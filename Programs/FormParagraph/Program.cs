using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ConsoleTable;

namespace FormParagraph
{
    class Program
    {        
        public static string BulletPara(string textToFind, int strFindIndex, string content)
        {
            var checkBullet = true;
            var nextBulletLineIndex = 0;
            var nextBulletIndex = 0;
            var retbulletPara = textToFind;
            // var removeNonBulletHeaders = Regex.Matches(retbulletPara,@"([\w\d]+\.\s)");
            // if (removeNonBulletHeaders.Count > 0)
            // {
            //     retbulletPara = textToFind.Remove(removeNonBulletHeaders[0].Index,removeNonBulletHeaders[0].Length).Trim() + ":";
            // }
            var startPara = string.Empty;
            var bulletStart = strFindIndex + textToFind.Length + 1;
            while(checkBullet)
            {
                // Console.Write(bulletStart);
                // Console.WriteLine(content[bulletStart]);
                nextBulletLineIndex = content.IndexOf((char)10,bulletStart+1);
                if(!content.IndexOf((char)183, bulletStart+1).Equals(0))
                {
                    nextBulletIndex = content.IndexOf((char)183,bulletStart+1);
                }
                if((Regex.IsMatch(content.Substring(bulletStart),@"\([\w\d+]\)") || Regex.IsMatch(content.Substring(bulletStart),@"[\w\d+]\)")))
                {
                    var nextalphabetBulletIndex = Regex.Matches(content.Substring(bulletStart+1),@"\([\w\d+]\)");
                    //var nextalphabetBulletIndex1 = Regex.Matches(content.Substring(bulletStart),@"[\w\d+]\)");

                    if(nextalphabetBulletIndex.Count > 0 && nextalphabetBulletIndex[0].Index < nextBulletIndex)
                    {
                        //nextBulletIndex = nextalphabetBulletIndex[1].Index;
                        nextBulletIndex = content.IndexOf(nextalphabetBulletIndex[0].Value);
                    }
                    // else if(nextalphabetBulletIndex1.Count > 0 && nextalphabetBulletIndex1[0].Index < nextBulletIndex)
                    // {
                    //     nextBulletIndex = nextalphabetBulletIndex1[0].Index;
                    // }
                }
                if(!content.IndexOf((char)194,bulletStart+1).Equals(0) && nextBulletIndex == -1)
                {
                    nextBulletIndex = content.IndexOf((char)194,bulletStart+1);
                }
                var checkNumberedList = Regex.Matches(content.Substring(bulletStart),@"(\n[\d]+\.)");
                if(nextBulletIndex == -1 || checkNumberedList.Count !=0) 
                {
                    var nextNumberedBulletIndex = 0;
                    if(checkNumberedList.Count != 0) 
                    {
                        nextNumberedBulletIndex = checkNumberedList[0].Index + bulletStart + 1;
                    }
                    if(!((nextBulletIndex - nextBulletLineIndex == 0) || (nextBulletIndex - nextBulletLineIndex == 1)))
                    {
                        nextBulletIndex = nextNumberedBulletIndex;
                    }
                }
                
                byte[] asciiBytes = System.Text.Encoding.UTF8.GetBytes("\n\n".ToString());
                // Console.WriteLine((char)8226);
                // Console.WriteLine((char)63); ?
                // Console.WriteLine((char)194); •
                // Console.WriteLine((char)183); ·
                // Console.WriteLine((char)10); New Line Character
                if((nextBulletIndex - nextBulletLineIndex == 0) || (nextBulletIndex - nextBulletLineIndex == 1))
                {
                    if(nextBulletLineIndex > 0)
                    {
                        retbulletPara += "\n" + content.Substring(bulletStart,nextBulletLineIndex - bulletStart);
                    }
                    else
                    {
                        retbulletPara += "\n" + content.Substring(bulletStart);
                    }
                    
                }
                else
                {
                    retbulletPara += "\n" + content.Substring(bulletStart,nextBulletLineIndex - bulletStart);
                    var checkIfHeading = Regex.Matches(retbulletPara,@"(\n[\w\d]+\.)"); // \nB. \nC. \n1.
                    if(checkIfHeading.Count != 0) 
                    {
                        var checkIfheadingIndex = checkIfHeading[checkIfHeading.Count - 1].Index;
                        if(checkIfheadingIndex > 500)
                        {
                            retbulletPara = retbulletPara.Remove(checkIfheadingIndex);
                        }
                    }
                    checkBullet = false;
                }
                if(nextBulletIndex > 0)
                {
                    bulletStart = nextBulletIndex;
                }
                else{
                    break;
                }
                
            }
            return retbulletPara;
        }

        public static string TablePara(string finalstartPara)
        {
            var tableStart = finalstartPara.IndexOf("\n\t");
            var tableEnd = finalstartPara.IndexOf("\n\n\n") < 0 ? finalstartPara.Length : finalstartPara.IndexOf("\n\n\n");
            
            var checktableContent = finalstartPara.Substring(tableStart, tableEnd - tableStart);

            return finalstartPara.Replace(checktableContent, "\n [table: ]");
        }

        public static string[] SpliceText(string[] text, int lineLength,int noCol) 
        {
            var splicedTextMainArray = new List<string>();
            foreach (var item in text)
            {
                splicedTextMainArray.Add(Regex.Replace(item, "(.{" + lineLength + "})", "$1" + Environment.NewLine));
            }
            String[] retArray = splicedTextMainArray.ToArray();
            return retArray;
        }

        public static string SpliceText(string text, int lineLength) 
        {
            return Regex.Replace(text, "(.{" + lineLength + "})", "$1" + Environment.NewLine);
        }
        static void Main(string[] args)
        {
            // Confidential
            //var content = "2. SUMMARY\n\nAs an employee of Microsoft, you have access to technical, financial and business information about Microsoft and/or third parties that is not available to the general public. Keeping this information confidential is critical to the success of our business, and helps strengthen our reputation as a company that can be trusted with the confidential information of others. \nWhen you joined Microsoft, you signed a non-disclosure agreement in which you agreed to protect this information. You must take steps to properly protect confidential information both inside and outside the office. \n​Do not disclose Microsoft confidential information unless there is a compelling business reason to do so, and you have obtained a non-disclosure agreement. If you cannot obtain a non-disclosure agreement, first review your potential disclosure with your CELA contact and then seek approval from a General Manager level or above. \nDo not disclose third party confidential information without express consent from the third party. \n\n3. REQUIREMENTS\n\nA. What is Confidential Information? \nConfidential Information is information related to our business or that of a third party that is not readily available to the general public. Confidential information is confidential whether or not it is explicitly designated 'confidential' or 'proprietary'. \nVirtually everyone at Microsoft creates, uses and/or has contact with confidential information in the course of doing their job. It is included in documents and email, exchanged in telephone and hallway conversations and discussed in meetings. \nCommon examples of confidential information include:\n· Source code\n· Pre-release builds\n· Data sets, data bases\n· Compilations of information\n· Algorithms\n· Technical know-how\n· Product plans and specifications\n· Milestones and usability surveys\n· Test results and bug data\n· Sales and marketing information and competitive intelligence\n· Competitive bid information, strategies, and pricing \n· Earnings, forecasts, and financial reporting information\n· Business or legal strategies. \n· Material non-public information as defined in Microsoft's Insider Trading Policy\nB. Do Not Disclose Confidential Information\nDo not disclose confidential information outside Microsoft unless:\n· There is an explicit compelling business need to do so and the person or company receiving the information has signed a Microsoft-approved non-disclosure agreement (NDA). \n· If disclosing third party confidential information, you have consent from the third party.\n· If a non-disclosure agreement is not in place, you first review your potential disclosure with your CELA contact and then seek approval from a General Manager level or above. \nC. Protect Microsoft Confidential Information\nYou must take reasonable steps to protect Microsoft's confidential information. That means being careful both inside and outside the office: \n· Share confidential information with colleagues on a need-to-know basis only. Your co-workers may not need the same information you do in order to do their job.\n· Do not share confidential information with friends, family members or former colleagues.\n· Be sure access to internal resources like intranet and SharePoint sites is set appropriately.\n· Do not post confidential information to social media sites or blogs. Blogging, commenting, and tweeting are not different than any other communication when it comes to confidential information. \n· Be aware of your surroundings. Do not discuss confidential information in public places like lobbies, elevators, gyms, airports and other public places where others may overhear, or work with documents containing confidential information in public places where people may see the information contained in them.\n· Remove confidential information on whiteboards at the conclusion of meetings.\n· Practice secure computing in accordance with the Standards and Guidelines on ITWeb.\nD. Protecting Third Party Confidential Information\nThird parties count on us to protect their information as carefully as we do our own. Never disclose third-party confidential information without the third party's consent.\n· Never disclose confidential information of a former employer.\n· Never ask or expect colleagues to disclose confidential information of their former employers. \n· Do not share supplier confidential information (for example, in a request for proposal or proof of concept) to other suppliers.\n· Do not disclose customers' confidential information.\n· Do not use confidential information provided inadvertently by a colleague about a former employer.\n· Always treat the information provided by third parties the same way you treat Microsoft information.\n· Do not disclose or share third parties' confidential information after leaving Microsoft.\n· Notify your CELA contact if there has been an inadvertent disclosure.\nE. Ask Questions\n[bookmark: _Hlk31187932]If you have any questions about this policy or how it applies under certain circumstances, contact your CELA contact. \nIf you have any concerns that confidential information may have been disclosed inappropriately, contact CELA right away.\n\n4. PROCEDURE\n\n​Follow this procedure to put in place a Microsoft-approved NDA before disclosing confidential information to a third party:\n1. Do not sign the third party's non-disclosure agreement. Instead, require that the third party sign a Microsoft-approved non-disclosure agreement:\n1. In the U.S. use the non-disclosure agreement (NDA) tool to create a standard Microsoft NDA. \n2. Outside the U.S., use the standard Microsoft non-disclosure form localized for your country's laws and language. Contact your subsidiary's CELA representative for more information on localized non-disclosure agreements. \n2. If the third party refuses to sign Microsoft's non-disclosure agreement, contact your CELA representative for assistance. \n\n5. EXCEPTIONS\n\n​The policy owner may approve exceptions to this policy.";

            // Document Retention
            // var content = "\n\n2. SUMMARY\n\n​You must follow the document management and retention requirements provided in this policy in order to meet legal obligations and business needs. \n\n3. REQUIREMENTS\n\nA. General Requirements\n\nMicrosoft is required to retain certain documents for a set time period to meet its legal obligations, and may also choose to retain certain documents in order to meet long-term business needs. \nYou must keep documents according to the Corporate Document Retention Schedule ('Schedule'). When retaining and storing the document, you must ensure that it is (1) accessible in the form prescribed in the Schedule; (2) legible and without deterioration; and (3) easily retrievable. \nA 'document' includes all recorded information, data or communication, regardless of its format, with the exception of voicemail messages and social media such as Yammer. The period for which a document is retained is dependent on:\n· Its content\n· Its business function​\n· Legal obligations\n· Business value\n· Whether the document is an original or a copy of a document \nAn 'original document' means a hard-copy with original ink signatures, a scan of a hard-copy with original ink signatures, or a document which has been wholly electronically signed. Do not retain a document for longer than the time period stated in the Schedule. Retention times apply to original documents as well as copies. \nB. Legal Hold Notices\nIf you receive a document preservation notice from CELA notifying you that documents you possess may be relevant to a current or anticipated litigation proceeding, audit, or government investigation, you may not delete or destroy any documents in your possession that are subject to the legal hold. The legal hold notice overrides the routine document processing and destruction practices set forth in the Corporate Document Retention Schedule. You will be notified when you may resume routine document processing and destruction practices. ​​\nC. Document Destruction Requirements \nDocuments eligible for disposal or destruction must follow the CorpRM document destruction requirements using the links below:\n· Disposal of employee managed documents (all formats and locations such as SharePoint, etc.)\n· D​isposal of documents store with Records Operations (Recman)\n· Unsure of what you have or if it’s eligible? Email CorpRM\nD. Manager Responsibilities\nIf you are a manager, you must ensure that your direct reports understand their obligations under this policy. \nDo not develop or implement other document retention policies or schedules. If you need a supplement to the Schedule, you must coordinate with and gain approval from Corporate Records Management.\nE. Questions \n\nIf you have a question about this policy or its application, contact Corporate Records Management.\n\n4. PROCEDURE\n\n​None​\n\n5. EXCEPTIONS\n\n​Submit requests for policy exceptions to Corporate Records Management for approval.";

            // Volume Licensing Prohibited
            //var content = "2. Summary\nWhen we negotiate commercial licensing deals, we trust our employees to make ethical decisions within their empowerment (see Commercial Licensing Contract Customization Policy).  However, there are some types of activities that are never permitted in commercial licensing because they may result in inaccurate financial reporting, damage Microsoft’s relationships with channel partners and customers, or decrease shareholder value.  \nThis is not an exhaustive list of all activities and behaviors that are prohibited, but a sample of common scenarios that are not expressly covered by other policies (see section “Related Documents”).\n3. Requirements \nDo Not Submit an Agreement for Signature Before it is Fixed and Final\nAll agreements must reflect a true and accurate statement of the facts upon which they are based.  You must not submit an agreement for signature that is not final or which omits any terms and conditions agreed upon with the customer.  Before submitting an agreement for signature, you must:\n(1) finalize all negotiations;\n(2) obtain and document approval for any concessions as required by the Empowerment Guide;\n(3) include all required documents in the agreement package, including the initial order and any required amendments;\n(4) ensure the agreement accurately states all agreed terms and conditions.  If a concession includes commitments made in other non-CL agreements, be sure that those other agreements are documented in an amendment;\n(5) ensure the initial order includes all quantities of products, qualified desktops or qualified users for which the customer intends to license at the time of signing.\nThese are the most common activities prohibited by this section:\n· Submitting an agreement for signature and promising (either orally or in writing) a customer a change of terms after the agreement has been submitted This applies to any terms and conditions in the arrangement, including non-financial terms, such as Privacy or Online Terms and Conditions or promising terms that are not aligned with Credit Term Extension Policy; \n· Submitting True-up order with the Initial Order (see Guidance);\n· Submitting an Initial Order the does not include all quantities of all products, qualified desktops or qualified users that the customer plans to license (see Guidance).\nDelaying a Credit\nDo not delay a credit to a subsequent fiscal quarter or fiscal year to avoid a revenue impact in the current period.  If a customer or partner is due a credit from Microsoft, you must work with the customer or partner to resolve the situation and issue the credit within the current fiscal quarter.\nAfter the Fact Discounting\nIn Indirect Model in both Public and Commercial Sector, you may not provide pricing concessions “after-the-fact” (i.e., granting an additional discount to a Partner after the financial bid opening) unless the customer explicitly requested the concession in writing, and the subsidiary Compliance Committee approves. \nPrice Negotiations for Indirect Agreements\nWhen Microsoft sells through a reseller, the price that the end customer pays must be determined solely by the reseller.  Influencing end-customer prices can erode trust with Microsoft’s Partner community, violate antitrust laws, and ultimately hurt our business.\nYou may not set, negotiate or guarantee customer pricing for agreements sold through a reseller. \n4. Procedure  \n\nN/A. \n5. Exceptions\nAny exceptions have to be approved by the policy owner.";

            // Giving Gifts - Commercial Recepients
            var content = "1.  Determine the Type of Program: Rebate or Marketing Payment to Partner\nAll programs where Microsoft gives cash to Partners need to be properly classified as rebate programs or marketing programs.\nA rebate is defined as a return of a pre-determined portion of the selling price to a Partner. An example in the Partner context is a payment made to the Partner for achieving certain sale performance criteria (providing Microsoft with sell-out reporting, paying on time or reaching per unit sales targets). Rebates are funds that a Partner can generally spend or use at its discretion, including to achieve a lower street price or to maximize margin. \nAll rebates must be administered and paid by a Microsoft Licensing entity or Limited Risk Distributor (LRD) (e.g., MIOL, MCCL, etc.) For further guidance on accounting for and administering rebate programs please refer to Payments to Partners and Customers Policy. \nFor Commercial please refer to the Partner Incentives Coop Guide here.  This guide includes examples of allowable marketing activities for Commercial partners, eg. managed resellers, distributors, CSPs and Hosting partners.\nFor Retail Offers please see CDS Offers Procedure and program maps available here.\nA marketing payment to partner is defined as a payment or reimbursement by Microsoft to a Partner for marketing, advertising, and/or promoting Microsoft products. These payments or reimbursements include Co-marketing, JMA, MDF, Reseller Marketing Fund, and similar programs.   and must be classified as either expense which is a revenue adjustment or expense which is Opex for accounting purposes. \nFor detail as to how to apply this policy to Sales Performance Incentive Fund Framework programs ('SPIFFs') see SPIFF Requirements Procedure.\nThe remainder of this procedure does not apply to rebates. \n2. Classify the Marketing Payments to Partners Reduction in Revenue (Revenue Adjustment)  or Expense (OPEX)\nIf the program is classified as a marketing program, the related payment needs to be classified as either an expense which is classified as Opex or a revenue adjustment by applying the criteria in the table below.\n\tClassification as Revenue Adjustment (3 criteria) \n\tClassification as Expense (5 criteria)\n\n\tMust be cash or cash equivalent\n\tMust be cash or cash equivalent \n\n\tMust be paid to (1) a Partner/Customer (not to a vendor or other third party) or (2) a Third Party Payment Provider (3PP) in order to pay a Partner provided the Partner has a buy/sell relationship with Microsoft and the payment to the 3PP is made according to the requirements in the global payouts policy \n\tMust be paid to (1) a Partner (not to a vendor or other third party) or (2) a Third Party Payment Provider (3PP) are permitted in order to pay a Partner provided the Partner has a buy/sell relationship with Microsoft and the payment to the 3PP is made according to the requirements in the global payouts policy\n\n\tMust be paid for marketing activities executed on Microsoft's behalf \n\tMust be paid for marketing activities executed on Microsoft's behalf\n\n\t\n\tPlus:  Payment is in Exchange for a distinct good or service\n\n\t\n\tPlus: The fair value of such goods or service can be reasonably estimated and documented\n\n\nNote that, in order to be classified as a expense (Opex), the payment must satisfy two conditions that are not required for revenue adjustment: the payment must be in exchange for distinct goods and services  and the fair  value of the good or service  must be able to be reasonably estimated  and documented. If either of these two additional conditions are not met, the payment must be classified as revenue adjustment.\nPlease refer to segment specific program maps and guidebooks for further clarity. For CDS please consult the CDS HUB  -Business and Investment Programs\nUse this flow chart to help you classify the marketing payment to partner as a revenue adjustment or expense:\n[image: ]\nMS Customer for the purposes of the flow chart means a Partner or customers that has buy or a buy/sell relationship with Microsoft products or services (both through direct or indirect channels). (ie. Software advisors don't count) Buy sell Partners/Customers are those who provide a service to Microsoft's customers in which the rights to Microsoft products or services are transferred to them at any point in the sales process.\nA distinct good or service to Microsoft is a separately identifiable benefit in addition to any increase in sales (e.g., advertising for Microsoft products and services paid for by our customer with the funds provided to the partner/customer). A distinct good or services (separately identifiable benefit) is received if Microsoft could purchase the service or product from another party that is not a customer.   \nAssessment of the fair value of the benefit would be a reasonably estimated amount for which a similar benefit could be obtained from a third party. Examples of ways to estimate fair value include invoices from third parties or published price lists for comparable products/services. \nNote: Contact Corp Accounting (RevRec alias) if the amount paid to partners and/or customers exceeds the fair value of the good or service\nAcceptable examples to determine FV:\n1. Third Party Invoices.  A 3rd Party Invoice is ideal for determining FV.  The face value of the 3rd Party Invoice would need to be greater or equal to the payment to customer/partner.  Example:  MSFT pays Local OEM $100 for a training conference.  Local OEM provides MSFT ABC Event Company’s invoice of $150.  Non-negotiable published rate card where rates are consistent for all the partner’s vendor base.  Example, Retailer has non-negotiable published price list for advertising in weekly circular.\n \nNot acceptable examples to determine FV:\n1. Partner’s negotiable price rates.  MSFT and Local OEM agree that MSFT will pay $XXX amount for joint advertising.  Local OEM does not have a published price list that can be shared, and the payment amount could be negotiated.  This is most common scenario as typically price rates are negotiated with partners\n1. Partner’s Internally created invoice.  MSFT pays Disti to advertise in Disti circular, including creation of the ad.  Disti provides MSFT with internal invoice for ad creative.  Since invoice is internally generated by payee and there is no additional support (i.e. similar priced quotes from other agencies) there is not enough information points to determine FV.\nWhen Opex GL account is used, evidence of Fair Value (FV) such as list pricing or quotation need to be retained before execution of marketing activity.  \n2.1. Cost Elements to Use for Marketing Payments to partners\nIt is the subsidiary or business unit controller’s responsibility to ensure that the accounting for partner payments is accurate. Evidence of monthly review of the accounting should be retained for audit purposes\n\n2.1.1 For all businesses (Excluding CDS) -Revenue Adjustment\nAll marketing payments to partners classified as revenue adjustment should be booked to 802018 account. All expenses in this account should then be reclassed at the end of each month to 525005. Every month this account will get reclassed to revenue adjustment in the Corp HQ P&L and not in the sub P&L. This will be done by finance in Corp HQ.  \nAll marketing payments to partners classified expense (Opex) should be coded to one of the thru partner marketing codes listed for Opex in table 2.1.3 below.\n2.1.2 For CDS- Revenue Adjustment\nAll marketing payments to partners classified as revenue adjustment should be booked directly to the 5 series cost elements. The direct posting to the 5 series cost elements are allowed so long the revenue adjustments are processed on the same SAP company code as the revenue. For a list of these LRD and MSLI entities, please refer to section 4. Country or Business Unit Supplement\nFor mini-ROCs and commissioners, where revenue is not processed on the same SAP company code, marketing payments to partners classified as revenue adjustment should be reclassed to the SAP company code where the revenue sits (i.e. 1010, 1429, 1062).\nAll expenses in these accounts should then be reviewed at the end of each month by the subsidiary controller or their delegate/team to ensure proper coding from both management and statutory P&L. \nMarketing payments to partners classified expense (Opex) should be booked to the 8 series according to Microsoft Chart of Accounts for marketing expenses. \n[bookmark: _Hlk27639448]\n2.1.3. Table Cost Elements/GL account \n\tRevenue Adjustments Cost Element\n\tSpend Type\n\tCDS Field\n\tOEM Non Field\n\tCommercial\n\tOther\n\n\t802018\n\tMDF & Co-Marketing : reclass to  525005\n\t \n\t \n\tx\n\tx\n\n\t807028\n\tPartner Sales Incentives (incl. SPIF): reclass to 525021\n\t \n\t \n\tx\n\tx\n\n\t525005\n\tCDS MDF & Co-Marketing\n\tx\n\t \n\t \n\t \n\n\t525021\n\tPartner Sales Incentives (incl. SPIF)\n\tx\n\t \n\t \n\t \n\n\t570004\n\tProWins Accelerator \n\tx\n\t \n\t \n\t \n\n\t570021\n\tEduWins Accelerator \n\tx\n\t \n\t \n\t \n\n\t525009\n\tCDS MDF Shopper Communication\n\tx\n\t \n\t \n\t \n\n\t525010\n\tCDS MDF Promotional/Premium Display\n\tx\n\t \n\t \n\t \n\n\t525011\n\tCDS MDF Assortment Fees\n\tx\n\t \n\t \n\t \n\n\t525012\n\tCDS MDF Fixture Fees\n\tx\n\t \n\t \n\t \n\n\t525013\n\tCDS MDF Product Listing Fees\n\tx\n\t \n\t \n\t \n\n\t525030\n\tCDS MDF Partner Training and Events\n\tx\n\t \n\t \n\t \n\n\t570186\n\tDiscretionary Revenue Adjustments (DRA)\n\t \n\tx\n\t \n\t \n\n\t\n\t\n\t\n\t\n\t\n\t\n\n\tOpex Cost Elements\n\t \n\t \n\tCommercial\n\tOther\n\n\t809010\n\tThru Partner and Co-Funded Advertising\n\t \n\tx\n\tx\n\n\t802059\n\tMDF and Co-Mktg-Opex Unallocated\n\t  \n\tx\n\tx\n\n\t805018\n\tVisual Merchandising (POS)\n\t  \n\tx\n\tx\n\n\t805023\n\tIn Store Demo & Display\n\t\n\tx\n\tx\n\n\t805024\n\tCDS Online Marketing\n\t \n\tx\n\tx\n\n\t807027\n\tThru Partner and Co-Funded Events\n\t\n\tx\n\tx\n\n\t807029\n\tLabor - Marketing *\n\t \n \n\tx\n\tx\n\n\n* For CDS,  labor marketing is allowed provided 1) it’s an eligible marketing activity under the program/framework from which the funds are provided; 2) MS has no influence or involvement over the relationship between the partner and the partner’s hired headcount; and 3) local laws and regulations allow it and are adhered to.\n3. Ensure Compliance Requirements \n3.1. Administration of Marketing Payments to Partners\nAll marketing payments to partners can be issued and administered by a Microsoft marketing entity, such as a local subsidiary. \nBy way of comparison, ALL rebates must be issued and administered exclusively by a Microsoft licensing entity or Limited Risk Distributor (LRD) (e.g., MIOL, MCCL, UK, etc.). \nRebates must NOT be issued by a Microsoft marketing entity, such as a local subsidiary. \nIf the arrangement with the Partner includes a rebate and a marketing element, the arrangement must be administered through and paid by the licensing entity or LRD (e.g., MIOL, MCCL, etc.). In addition, if the arrangement is linked to sales volume attainment (Other than those programs which meet the requirements in the SPIFF procedure) it must be administered through the licensing entity/ LRD.\n[bookmark: _Hlk26395838]3.2. Contracting Requirements\nFor Commercial please see the Commercial contracting requirements and agreement templates at this link.\nFor CDS Please see this link for contracting requirements\nEnsure Authorized people will sign the contract and ensure Safe limits  approval are activated before creating POs. https://msauthorize.microsoft.com \n3.3. Marketing Programs\nAll marketing programs (whether classified as revenue adjustment or Opex and including SPIFFS) with a Partner need to be properly documented. If local Finance or compliance are not clear whether the arrangement could be considered a rebate, they should review with their regional compliance lead who should escalate to the Corp Segment compliance lead if necessary. Please also confer with the Marketing Payments to Partners and SPIFF questions alias if there is any doubt as to how to account for a marketing program (mktgpaymentsandspiff@microsoft.com) \n3.4. Purchase Order\nA PO is required for all marketing programs in all channels. The PO should contain a detailed description. Depending on local laws/regulations, there may be additional contractual requirements. Please confer with local CELA and Tax to determine the applicability of local legal and tax requirements and comply as required.   It is Program Owner responsibility to educate the partners that marketing activities cannot be started until the purchase Order (PO) gets approved. \n3.5. Proof of Execution ('POE'). \nPOE must be obtained and retained for marketing payments to partners according to the  Proof of Execution policy and related procedures which also provides clarity as to when POE is required to be uploaded into MS Invoice.\n3.6. Payment Approval Requirements:\n Prior to payment approvals, the invoice approver should determine that the payment requested in the invoice by the Partner has met any agreed upon service level agreements. In addition for marketing payments , relevant POE should be uploaded in MS Invoice where required by the MDF POE Procedure.\nApprove invoices only when services/goods have been executed/received per agreed unless formerly agreed and approved by finance per Prepayment Policy (Procurement policy)\nPayments should not be made by a distributor to a reseller/retailer on Microsoft's behalf unless that distributor is an approved 3PP under the 3PP policy. \nQuestions on programs or this policy should be addressed to Marketing Payments to Partners and SPIFF questions alias (mktgpaymentsandspiff@microsoft.com)\n3.7. Accrual for Open Purchase Orders\nAccrue through CIM Portal  for POs where goods and services received have not been yet invoiced. If PO information is not in CIM or your area does not use CIM, accrual requests should be submitted to CAC Finance / Local Finance with valid POE.\n\nClose the PO once the service/ good has been received and paid to release unused funds.\nFrequently Asked Questions: \nA frequently asked questions (FAQ) document has been developed in conjunction with this procedure. This can be found here. This FAQ will be regularly updated as new questions arise.\n\n";
            
            var textToFind = "Not acceptable examples to determine FV:"; //.Trim('o','•','·','\t');
            // Working - · Its content
            // Working - • Business value
            // Working - • Legal obligations
            // Working - · D​isposal of documents store with Records Operations (Recman)
            // Working - Retention times apply to original documents as well as copies.
            // Working - • Disposal of employee managed documents (all formats and locations such as SharePoint, etc.)
            // Working - Do not develop or implement other document retention policies or schedules. If you need a supplement to the Schedule, you must coordinate with and gain approval from Corporate Records Management.
            // Working - If you receive a document preservation notice from CELA notifying you that documents you possess may be relevant to a current or anticipated litigation proceeding, audit, or government investigation, you may not delete or destroy any documents in your possession that are subject to the legal hold.
            // Working - You must follow the document management and retention requirements provided in this policy in order to meet legal obligations and business needs.
            // Working - You must keep documents according to the Corporate Document Retention Schedule ('Schedule').
            // Working - An 'original document' means a hard-copy with original ink signatures, a scan of a hard-copy with original ink signatures, or a document which has been wholly electronically signed.
            // Working - Microsoft is required to retain certain documents for a set time period to meet its legal obligations, and may also choose to retain certain documents in order to meet long-term business needs. 
            // Working - A 'document' includes all recorded information, data or communication, regardless of its format, with the exception of voicemail messages and social media such as Yammer.
            // Working - The period for which a document is retained is dependent on:
            // Working - Submit requests for policy exceptions to Corporate Records Management for approval.
            // This policy defines business expenses for which Microsoft reimburses employees.
            //Auto fines including traffic tickets, parking violations, and towing fees.";
            //•	Purchases of directly competitive hardware and devices.
            //Violation of this policy may result in disciplinary action, up to and including termination of employment.
            //Microsoft reimburses employees for necessary and reasonable business expenses outlined below.
            //•	Reviewed and approved by managers with the appropriate level of Microsoft Signature Authorization for Expenditures (SAFE) authority.
            //o	This includes Surface, Xbox, HoloLens, Surface Headphones, Office and Azure.
            //•	Purchases of fixed assets: hardware (personal computers or laptops), furniture, or other equipment.
            
            var strFindIndex = content.IndexOf(textToFind.Trim('o','•','·','\t'));
            var lastFindIndex = content.IndexOf((char)10,strFindIndex+1);
            var start = strFindIndex - 1;
            var beginning = 0;
            var summaryWords = new List<string>();
            var temp = 0;
            var at = 0;
            var count = 0;
            var end = 0;
            var nextLineIndex = 0;
            var startPara = string.Empty;
            var nextDoubleLineIndex = 0;
            var bulletPara = string.Empty;
            byte[] asciiByte = System.Text.Encoding.UTF8.GetBytes(".".ToString());
            var nextHeadingIndex = 0;
            // Console.WriteLine((char)8226);
            
            try 
            {
                if(textToFind.EndsWith(':'))// || textToFind.StartsWith('·') || textToFind.StartsWith('•'))
            {
                bulletPara = BulletPara(textToFind,strFindIndex,content);
            }

            if(start < 50)
            {
                beginning = start + 250;
            }            

            end = start/2 - 1;
            var indexes = new List<int>();

            // while((start > -1) && (at > -1))
            // {
            //     count = start - end; //Count must be within the substring.
            //     at = content.LastIndexOf("\n\n\n", start, count);
            //     if (at > -1 && indexes.Count == 0)
            //     {
            //         indexes.Add(at);
            //         Console.Write("{0} ", at);
            //         start = at - 1;
            //     }
            //     else{
            //         count = 0;
            //         at = 0;
            //         break;
            //     }
            // }

            while((start > -1) && (at > -1))
            {
                count = start - end; //Count must be within the substring.
                at = content.LastIndexOf("\n\n", start, count);
                if (at > -1 && indexes.Count == 0)
                {
                    indexes.Add(at);
                    //Console.Write("{0} ", at);                    
                    if((start - at) == 1)
                    {
                        break;
                    }
                    start = at - 1;
                }
                else{
                    count = 0;
                    at = 0;
                    break;
                }
            }

            while((start > -1) && (at > -1))
            {
                if((start - at) == 1 && lastFindIndex > 0)
                {
                    nextLineIndex = content.IndexOf((char)10,lastFindIndex+1);
                    nextDoubleLineIndex = content.IndexOf("\n\n",lastFindIndex+1);
                    if(nextDoubleLineIndex < nextLineIndex && nextDoubleLineIndex > 0)
                    {
                        nextLineIndex = nextDoubleLineIndex;
                    }
                    break;
                }
                else
                {
                    count = start - end; //Count must be within the substring.
                    at = content.LastIndexOf("\n", start, count);
                    if (at > -1) 
                    {
                        indexes.Add(at);
                        //Console.Write("{0} ", at);
                        start = at - 1;
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            if (indexes.Count == 1 || indexes.Count > 10)
            {
                if(indexes.Count > 1)
                {
                    var headingCheck = Regex.Matches(content.Substring(indexes[1]),@"(\n[\w\d]+\.\s)");
                    if(headingCheck.Count != 0)
                    {
                        temp = indexes[1];
                    }
                    else
                    {
                        temp = indexes[0];
                    }
                }
                else{
                    temp = 0;                
                }
            }
            else if (indexes.Count > 1 && indexes.Count < 10)
            {
                var headingCheck = Regex.Matches(content.Substring(indexes[1]),@"(\n[\w\d]+\.\s)");
                    if(headingCheck.Count != 0 && headingCheck[0].Index < 50)
                    {
                        temp = indexes[1];
                    }
                    else
                    {
                        temp = indexes[indexes.Count - 1];
                    }
            }
            else
            {
                temp = 0;
            }            
            
            if((start - at) == 1)
            {
                startPara = content.Substring(temp,nextLineIndex - temp);
            }
            else{
                startPara = content.Substring(temp,(strFindIndex - temp)+textToFind.Length);
            }

            var checkHeading = Regex.Matches(startPara,@"(\n[\w\d]+\.)"); // \nB. \nC. \n1.

            if(checkHeading.Count != 0) 
            {
                var headingIndex = checkHeading[checkHeading.Count - 1].Index;
                startPara = startPara.Substring(headingIndex);
                if(!startPara.EndsWith('\n'))
                {
                    var searchNext = content.Substring(content.IndexOf(startPara));
                    var checkNextHeading = Regex.Matches(searchNext,@"(\n[\w\d]+\.)");
                    if(checkNextHeading.Count !=0)
                    {
                        if(checkNextHeading.Count > 1)
                        {
                            nextHeadingIndex = checkNextHeading[1].Index;
                        }
                        else{
                            nextHeadingIndex = checkNextHeading[0].Index;
                        }
                        
                        if(nextHeadingIndex < 50 && checkNextHeading.Count <= 1)
                        {
                            startPara = searchNext.Substring(checkNextHeading[0].Index);
                        }
                        else if(nextHeadingIndex < 50)
                        {
                            startPara = searchNext.Substring(checkNextHeading[0].Index,checkNextHeading[2].Index-checkNextHeading[0].Index);
                        }
                        else{
                            startPara = searchNext.Substring(checkNextHeading[0].Index,checkNextHeading[1].Index-checkNextHeading[0].Index);
                        }
                        
                    }
                }
            }

            if((startPara.Contains('·') || startPara.EndsWith(':')) && nextHeadingIndex.Equals(0))
            {
                // var findspecialchar = startPara.IndexOf(textToFind.Trim('o','•','·','\t'));
                // if(findspecialchar >= 0)
                // {
                //     startPara = startPara.Remove(findspecialchar,textToFind.Length);
                // }                
                var newBulletPara = BulletPara(textToFind.Trim('o','•','·','\t'),strFindIndex,content);
                var splitStartPara = startPara.Trim().Split('.',StringSplitOptions.RemoveEmptyEntries);
                if(splitStartPara.Length >= 2 && splitStartPara.Length <= 5)
                {
                    if ((!newBulletPara.Contains(splitStartPara[splitStartPara.Length - 1].Trim()) && newBulletPara.Contains(splitStartPara[splitStartPara.Length - 2].Trim())) && !newBulletPara.Contains(startPara.Trim()))
                    {
                        startPara += newBulletPara;
                    }
                    else if(newBulletPara.Length > startPara.Length)
                    {
                        startPara = newBulletPara;
                    }
                }
                else if(splitStartPara.Length > 5)
                {
                    if(splitStartPara[5].Length < 2)
                    {
                        startPara = String.Join(".",splitStartPara,0,splitStartPara.Length);
                    }
                    else if(splitStartPara.Length == 6)
                    {
                        startPara = String.Join(".",splitStartPara,0,5);
                    }
                     else
                    {
                        startPara = String.Join(".",splitStartPara,1,6);
                    }
                    
                }
                else
                {
                    startPara += newBulletPara;
                }
            }
            
            // if (beginning != 0)
            // {
            //     var words = content.Substring(temp,(beginning + textToFind.Length)).Split(' ');
            //     foreach (var word in words)
            //     {
            //         summaryWords.Add(word);
            //         totalCharacters += word.Length;

            //         if(totalCharacters > beginning)
            //             break;
            //     }
            // }
            
            // if(summaryWords.Count!= 0)
            // {
            //     var summary = string.Join(' ',summaryWords) + "...";
            //     Console.WriteLine(summary);
            // }
            // else
            // {
                if(string.IsNullOrEmpty(bulletPara))
                {
                    if(startPara.Contains('\t'))
                    {
                        var tabularStartPara = TablePara(startPara.Trim());
                        Console.WriteLine(tabularStartPara.TrimStart().TrimEnd());
                    }
                    else
                    { 
                        Console.WriteLine(startPara.TrimStart().TrimEnd());
                    }
                }
                else
                {
                    Console.WriteLine(bulletPara.TrimStart().TrimEnd());
                }
            //}
            
            //Console.WriteLine(strFindIndex);

            }
            catch(Exception ex)
            {
                Console.WriteLine("");
            }
            
        }
    }
}
