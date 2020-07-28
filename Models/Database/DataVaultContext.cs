using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProgrammaticFiltering.Models.Database
{
    public partial class DataVaultContext : DbContext
    {
        public DataVaultContext()
        {
        }

        public DataVaultContext(DbContextOptions<DataVaultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VlapDomoagentStateDetails> VlapDomoagentStateDetails { get; set; }
        public virtual DbSet<VlapDomocallLog> VlapDomocallLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VlapDomoagentStateDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VLap_DOMOAgentStateDetails");

                entity.Property(e => e.AfterCallWorkTime).HasColumnName("AFTER_CALL_WORK_TIME");

                entity.Property(e => e.Agent)
                    .HasColumnName("AGENT")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentDisconnectsFirst).HasColumnName("AGENT_DISCONNECTS_FIRST");

                entity.Property(e => e.AgentEmail)
                    .HasColumnName("AGENT_EMAIL")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentFirstName)
                    .HasColumnName("AGENT_FIRST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentGroup)
                    .HasColumnName("AGENT_GROUP")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentId)
                    .HasColumnName("AGENT_ID")
                    .HasMaxLength(300);

                entity.Property(e => e.AgentLastName)
                    .HasColumnName("AGENT_LAST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentName)
                    .HasColumnName("AGENT_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentStartDate)
                    .HasColumnName("AGENT_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.AgentStartMonth)
                    .HasColumnName("AGENT_START_MONTH")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentStartYear).HasColumnName("AGENT_START_YEAR");

                entity.Property(e => e.AgentStateTime).HasColumnName("AGENT_STATE_TIME");

                entity.Property(e => e.AgentStates).HasColumnName("AGENT_STATES");

                entity.Property(e => e.Ani)
                    .HasColumnName("ANI")
                    .HasMaxLength(20);

                entity.Property(e => e.AvailableForAll)
                    .HasColumnName("AVAILABLE_FOR_ALL")
                    .HasMaxLength(1000);

                entity.Property(e => e.AvailableForCalls)
                    .HasColumnName("AVAILABLE_FOR_CALLS")
                    .HasMaxLength(1000);

                entity.Property(e => e.AvailableForVm)
                    .HasColumnName("AVAILABLE_FOR_VM")
                    .HasMaxLength(300);

                entity.Property(e => e.CallId).HasColumnName("CALL_ID");

                entity.Property(e => e.CallSurveyResult)
                    .HasColumnName("CALL_SURVEY_RESULT")
                    .HasMaxLength(300);

                entity.Property(e => e.CallType)
                    .HasColumnName("CALL_TYPE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Calls).HasColumnName("CALLS");

                entity.Property(e => e.CallsUnansweredByAgent)
                    .HasColumnName("CALLS_UNANSWERED_BY_AGENT")
                    .HasMaxLength(5);

                entity.Property(e => e.Campaign)
                    .HasColumnName("CAMPAIGN")
                    .HasMaxLength(1000);

                entity.Property(e => e.CampaignType)
                    .HasColumnName("CAMPAIGN_TYPE")
                    .HasMaxLength(1000);

                entity.Property(e => e.ConferenceTime).HasColumnName("CONFERENCE_TIME");

                entity.Property(e => e.Conferences).HasColumnName("CONFERENCES");

                entity.Property(e => e.ConsultTime).HasColumnName("CONSULT_TIME");

                entity.Property(e => e.Consults).HasColumnName("CONSULTS");

                entity.Property(e => e.ConsultsAnswered)
                    .HasColumnName("CONSULTS_ANSWERED")
                    .HasMaxLength(5);

                entity.Property(e => e.ConsultsInitiated)
                    .HasColumnName("CONSULTS_INITIATED")
                    .HasMaxLength(5);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DateAndHour)
                    .HasColumnName("DATE_AND_HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.DayOfMonth).HasColumnName("DAY_OF_MONTH");

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("DAY_OF_WEEK")
                    .HasMaxLength(1000);

                entity.Property(e => e.DialTime).HasColumnName("DIAL_TIME");

                entity.Property(e => e.DisconnectedFromHold)
                    .HasColumnName("DISCONNECTED_FROM_HOLD")
                    .HasMaxLength(5);

                entity.Property(e => e.Disposition)
                    .HasColumnName("DISPOSITION")
                    .HasMaxLength(1000);

                entity.Property(e => e.DispositionGroupA)
                    .HasColumnName("DISPOSITION_GROUP_A")
                    .HasMaxLength(300);

                entity.Property(e => e.DispositionGroupB)
                    .HasColumnName("DISPOSITION_GROUP_B")
                    .HasMaxLength(300);

                entity.Property(e => e.DispositionGroupC)
                    .HasColumnName("DISPOSITION_GROUP_C")
                    .HasMaxLength(300);

                entity.Property(e => e.DispositionPath)
                    .HasColumnName("DISPOSITION_PATH")
                    .HasMaxLength(300);

                entity.Property(e => e.Dnis)
                    .HasColumnName("DNIS")
                    .HasMaxLength(255);

                entity.Property(e => e.EnabledForVideo)
                    .HasColumnName("ENABLED_FOR_VIDEO")
                    .HasMaxLength(300);

                entity.Property(e => e.EndTimeMillisecond)
                    .HasColumnName("END_TIME_MILLISECOND")
                    .HasMaxLength(300);

                entity.Property(e => e.Extension).HasColumnName("EXTENSION");

                entity.Property(e => e.HalfHour)
                    .HasColumnName("HALF_HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.HandleTime).HasColumnName("HANDLE_TIME");

                entity.Property(e => e.HoldTime).HasColumnName("HOLD_TIME");

                entity.Property(e => e.Holds).HasColumnName("HOLDS");

                entity.Property(e => e.Hour)
                    .HasColumnName("HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.HourOfDay).HasColumnName("HOUR_OF_DAY");

                entity.Property(e => e.LoginTime).HasColumnName("LOGIN_TIME");

                entity.Property(e => e.LoginTimestamp)
                    .HasColumnName("LOGIN_TIMESTAMP")
                    .HasMaxLength(50);

                entity.Property(e => e.LogoutTime).HasColumnName("LOGOUT_TIME");

                entity.Property(e => e.LogoutTimestamp)
                    .HasColumnName("LOGOUT_TIMESTAMP")
                    .HasMaxLength(50);

                entity.Property(e => e.LongAfterCallWork)
                    .HasColumnName("LONG_AFTER_CALL_WORK")
                    .HasMaxLength(5);

                entity.Property(e => e.LongCalls)
                    .HasColumnName("LONG_CALLS")
                    .HasMaxLength(5);

                entity.Property(e => e.LongHolds)
                    .HasColumnName("LONG_HOLDS")
                    .HasMaxLength(5);

                entity.Property(e => e.LongParks)
                    .HasColumnName("LONG_PARKS")
                    .HasMaxLength(5);

                entity.Property(e => e.ManualTime).HasColumnName("MANUAL_TIME");

                entity.Property(e => e.MediaAvailability)
                    .HasColumnName("MEDIA_AVAILABILITY")
                    .HasMaxLength(1000);

                entity.Property(e => e.MissedCalls)
                    .HasColumnName("MISSED_CALLS")
                    .HasMaxLength(300);

                entity.Property(e => e.MissedCallsReturned)
                    .HasColumnName("MISSED_CALLS_RETURNED")
                    .HasMaxLength(300);

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasMaxLength(1000);

                entity.Property(e => e.NotReadyTime).HasColumnName("NOT_READY_TIME");

                entity.Property(e => e.OnAcwTime).HasColumnName("ON_ACW_TIME");

                entity.Property(e => e.OnCallTime).HasColumnName("ON_CALL_TIME");

                entity.Property(e => e.OnVoicemailTime).HasColumnName("ON_VOICEMAIL_TIME");

                entity.Property(e => e.PaidTime).HasColumnName("PAID_TIME");

                entity.Property(e => e.ParkTime).HasColumnName("PARK_TIME");

                entity.Property(e => e.Parks).HasColumnName("PARKS");

                entity.Property(e => e.PreviewInterrupted).HasColumnName("PREVIEW_INTERRUPTED");

                entity.Property(e => e.PreviewInterruptedByCall).HasColumnName("PREVIEW_INTERRUPTED_BY_CALL");

                entity.Property(e => e.PreviewInterruptedBySkillVm)
                    .HasColumnName("PREVIEW_INTERRUPTED_BY_SKILL_VM")
                    .HasMaxLength(300);

                entity.Property(e => e.PreviewTime).HasColumnName("PREVIEW_TIME");

                entity.Property(e => e.QuarterHour)
                    .HasColumnName("QUARTER_HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.QueueCallbackProcessing)
                    .HasColumnName("QUEUE_CALLBACK_PROCESSING")
                    .HasMaxLength(300);

                entity.Property(e => e.QueueCallbackRegistered)
                    .HasColumnName("QUEUE_CALLBACK_REGISTERED")
                    .HasMaxLength(300);

                entity.Property(e => e.ReadyTime).HasColumnName("READY_TIME");

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("REASON_CODE")
                    .HasMaxLength(1000);

                entity.Property(e => e.RingTime).HasColumnName("RING_TIME");

                entity.Property(e => e.RingingTime).HasColumnName("RINGING_TIME");

                entity.Property(e => e.ShortAfterCallWork)
                    .HasColumnName("SHORT_AFTER_CALL_WORK")
                    .HasMaxLength(5);

                entity.Property(e => e.ShortCalls)
                    .HasColumnName("SHORT_CALLS")
                    .HasMaxLength(5);

                entity.Property(e => e.Skill)
                    .HasColumnName("SKILL")
                    .HasMaxLength(1000);

                entity.Property(e => e.SkillAvailability)
                    .HasColumnName("SKILL_AVAILABILITY")
                    .HasMaxLength(1000);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(1000);

                entity.Property(e => e.TalkTime).HasColumnName("TALK_TIME");

                entity.Property(e => e.TalkTimeLessHoldAndPark).HasColumnName("TALK_TIME_LESS_HOLD_AND_PARK");

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.TimeInterval)
                    .HasColumnName("TIME_INTERVAL")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeToReturnMissedCall)
                    .HasColumnName("TIME_TO_RETURN_MISSED_CALL")
                    .HasMaxLength(300);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimestampMillisecond)
                    .HasColumnName("TIMESTAMP_MILLISECOND")
                    .HasMaxLength(300);

                entity.Property(e => e.TransferredToAgent)
                    .HasColumnName("TRANSFERRED_TO_AGENT")
                    .HasMaxLength(5);

                entity.Property(e => e.TransferredToCampaign)
                    .HasColumnName("TRANSFERRED_TO_CAMPAIGN")
                    .HasMaxLength(5);

                entity.Property(e => e.TransferredToSkill)
                    .HasColumnName("TRANSFERRED_TO_SKILL")
                    .HasMaxLength(5);

                entity.Property(e => e.Transfers)
                    .HasColumnName("TRANSFERS")
                    .HasMaxLength(5);

                entity.Property(e => e.TransfersToSameQueue)
                    .HasColumnName("TRANSFERS_TO_SAME_QUEUE")
                    .HasMaxLength(5);

                entity.Property(e => e.UnavailableForCalls)
                    .HasColumnName("UNAVAILABLE_FOR_CALLS")
                    .HasMaxLength(1000);

                entity.Property(e => e.UnavailableForVm)
                    .HasColumnName("UNAVAILABLE_FOR_VM")
                    .HasMaxLength(300);

                entity.Property(e => e.UnpaidTime).HasColumnName("UNPAID_TIME");

                entity.Property(e => e.VideoTime)
                    .HasColumnName("VIDEO_TIME")
                    .HasMaxLength(300);

                entity.Property(e => e.VmInProgressTime).HasColumnName("VM_IN_PROGRESS_TIME");

                entity.Property(e => e.VoicemailHandleTime)
                    .HasColumnName("VOICEMAIL_HANDLE_TIME")
                    .HasMaxLength(300);

                entity.Property(e => e.Voicemails).HasColumnName("VOICEMAILS");

                entity.Property(e => e.VoicemailsDeclined)
                    .HasColumnName("VOICEMAILS_DECLINED")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsDeleted)
                    .HasColumnName("VOICEMAILS_DELETED")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsHandled)
                    .HasColumnName("VOICEMAILS_HANDLED")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsReturnedCall)
                    .HasColumnName("VOICEMAILS_RETURNED_CALL")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsTransferred)
                    .HasColumnName("VOICEMAILS_TRANSFERRED")
                    .HasMaxLength(5);

                entity.Property(e => e.WaitTime).HasColumnName("WAIT_TIME");

                entity.Property(e => e.Worksheet)
                    .HasColumnName("WORKSHEET")
                    .HasMaxLength(300);

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<VlapDomocallLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VLap_DOMOCallLog");

                entity.Property(e => e.AbandonRate)
                    .HasColumnName("ABANDON_RATE")
                    .HasMaxLength(20);

                entity.Property(e => e.Abandoned)
                    .HasColumnName("ABANDONED")
                    .HasMaxLength(5);

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("Account_Number")
                    .HasMaxLength(300);

                entity.Property(e => e.Address2).HasMaxLength(300);

                entity.Property(e => e.AfterCallWorkTime).HasColumnName("AFTER_CALL_WORK_TIME");

                entity.Property(e => e.Age).HasMaxLength(300);

                entity.Property(e => e.Agent)
                    .HasColumnName("AGENT")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentEmail)
                    .HasColumnName("AGENT_EMAIL")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentFirstName)
                    .HasColumnName("AGENT_FIRST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentGroup)
                    .HasColumnName("AGENT_GROUP")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentId)
                    .HasColumnName("AGENT_ID")
                    .HasMaxLength(300);

                entity.Property(e => e.AgentLastName)
                    .HasColumnName("AGENT_LAST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.AgentName)
                    .HasColumnName("AGENT_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.Amount).HasMaxLength(300);

                entity.Property(e => e.Ani)
                    .HasColumnName("ANI")
                    .HasMaxLength(20);

                entity.Property(e => e.AniAreaCode).HasColumnName("ANI_AREA_CODE");

                entity.Property(e => e.AniCountry)
                    .HasColumnName("ANI_COUNTRY")
                    .HasMaxLength(1000);

                entity.Property(e => e.AniCountryCode).HasColumnName("ANI_COUNTRY_CODE");

                entity.Property(e => e.AniState)
                    .HasColumnName("ANI_STATE")
                    .HasMaxLength(1000);

                entity.Property(e => e.AssignedAgent)
                    .HasColumnName("Assigned_Agent")
                    .HasMaxLength(300);

                entity.Property(e => e.BillTimeRounded)
                    .HasColumnName("BILL_TIME_ROUNDED")
                    .HasMaxLength(300);

                entity.Property(e => e.BusinessAnnualRevenue)
                    .HasColumnName("BUSINESS_ANNUAL_REVENUE")
                    .HasMaxLength(300);

                entity.Property(e => e.CallId).HasColumnName("CALL_ID");

                entity.Property(e => e.CallSurveyResult)
                    .HasColumnName("CALL_SURVEY_RESULT")
                    .HasMaxLength(300);

                entity.Property(e => e.CallTime).HasColumnName("CALL_TIME");

                entity.Property(e => e.CallType)
                    .HasColumnName("CALL_TYPE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Calls).HasColumnName("CALLS");

                entity.Property(e => e.CallsCompletedInIvr)
                    .HasColumnName("CALLS_COMPLETED_IN_IVR")
                    .HasMaxLength(5);

                entity.Property(e => e.CallsTimedOutInIvr)
                    .HasColumnName("CALLS_TIMED_OUT_IN_IVR")
                    .HasMaxLength(5);

                entity.Property(e => e.Campaign)
                    .HasColumnName("CAMPAIGN")
                    .HasMaxLength(1000);

                entity.Property(e => e.CampaignType)
                    .HasColumnName("CAMPAIGN_TYPE")
                    .HasMaxLength(1000);

                entity.Property(e => e.CampaignType1)
                    .HasColumnName("CampaignType")
                    .HasMaxLength(300);

                entity.Property(e => e.CcExpiration)
                    .HasColumnName("CC_Expiration")
                    .HasMaxLength(300);

                entity.Property(e => e.CcHolderName)
                    .HasColumnName("CC_Holder_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.CcToken)
                    .HasColumnName("CC_Token")
                    .HasMaxLength(300);

                entity.Property(e => e.CcType)
                    .HasColumnName("CC_Type")
                    .HasMaxLength(300);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(300);

                entity.Property(e => e.Client).HasMaxLength(300);

                entity.Property(e => e.Comments).HasMaxLength(300);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(300);

                entity.Property(e => e.ConferenceTime).HasColumnName("CONFERENCE_TIME");

                entity.Property(e => e.Conferences).HasColumnName("CONFERENCES");

                entity.Property(e => e.ConsultTime).HasColumnName("CONSULT_TIME");

                entity.Property(e => e.ContactCreateTimestamp)
                    .HasColumnName("CONTACT_CREATE_TIMESTAMP")
                    .HasMaxLength(1000);

                entity.Property(e => e.ContactCreatedDateTime)
                    .HasColumnName("Contact_Created_DateTime")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactId).HasColumnName("CONTACT_ID");

                entity.Property(e => e.ContactLastAgent)
                    .HasColumnName("Contact_Last_Agent")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactLastAgentDisposition)
                    .HasColumnName("Contact_Last_Agent_Disposition")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactLastAgentDispositionDateTime)
                    .HasColumnName("Contact_Last_Agent_Disposition_DateTime")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactLastCampaign)
                    .HasColumnName("Contact_Last_Campaign")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactLastDisposition)
                    .HasColumnName("Contact_Last_Disposition")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactLastDispositionDateTime)
                    .HasColumnName("Contact_Last_Disposition_DateTime")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactModifiedDateTime)
                    .HasColumnName("Contact_Modified_DateTime")
                    .HasMaxLength(300);

                entity.Property(e => e.ContactModifiedTimestamp)
                    .HasColumnName("CONTACT_MODIFIED_TIMESTAMP")
                    .HasMaxLength(1000);

                entity.Property(e => e.Contacted)
                    .HasColumnName("CONTACTED")
                    .HasMaxLength(5);

                entity.Property(e => e.Cost).HasColumnName("COST");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DateAndHour)
                    .HasColumnName("DATE_AND_HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.DayOfMonth).HasColumnName("DAY_OF_MONTH");

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("DAY_OF_WEEK")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgent)
                    .HasColumnName("DEST_AGENT")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgentEmail)
                    .HasColumnName("DEST_AGENT_EMAIL")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgentExtension)
                    .HasColumnName("DEST_AGENT_EXTENSION")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgentFirstName)
                    .HasColumnName("DEST_AGENT_FIRST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgentGroup)
                    .HasColumnName("DEST_AGENT_GROUP")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgentLastName)
                    .HasColumnName("DEST_AGENT_LAST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestAgentName)
                    .HasColumnName("DEST_AGENT_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.DialAttempt)
                    .HasColumnName("Dial_Attempt")
                    .HasMaxLength(300);

                entity.Property(e => e.DialTime).HasColumnName("DIAL_TIME");

                entity.Property(e => e.DisconnectedFromHold)
                    .HasColumnName("DISCONNECTED_FROM_HOLD")
                    .HasMaxLength(5);

                entity.Property(e => e.Disposition)
                    .HasColumnName("DISPOSITION")
                    .HasMaxLength(1000);

                entity.Property(e => e.DispositionGroupA)
                    .HasColumnName("DISPOSITION_GROUP_A")
                    .HasMaxLength(300);

                entity.Property(e => e.DispositionGroupB)
                    .HasColumnName("DISPOSITION_GROUP_B")
                    .HasMaxLength(300);

                entity.Property(e => e.DispositionGroupC)
                    .HasColumnName("DISPOSITION_GROUP_C")
                    .HasMaxLength(300);

                entity.Property(e => e.DispositionPath)
                    .HasColumnName("DISPOSITION_PATH")
                    .HasMaxLength(300);

                entity.Property(e => e.Dnis)
                    .HasColumnName("DNIS")
                    .HasMaxLength(255);

                entity.Property(e => e.DnisAreaCode).HasColumnName("DNIS_AREA_CODE");

                entity.Property(e => e.DnisCountry)
                    .HasColumnName("DNIS_COUNTRY")
                    .HasMaxLength(1000);

                entity.Property(e => e.DnisCountryCode).HasColumnName("DNIS_COUNTRY_CODE");

                entity.Property(e => e.DnisState)
                    .HasColumnName("DNIS_STATE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(300);

                entity.Property(e => e.Ex1).HasMaxLength(300);

                entity.Property(e => e.Ex2).HasMaxLength(300);

                entity.Property(e => e.Ex3).HasMaxLength(300);

                entity.Property(e => e.Ex4).HasMaxLength(300);

                entity.Property(e => e.Ex5).HasMaxLength(300);

                entity.Property(e => e.Extension).HasColumnName("EXTENSION");

                entity.Property(e => e.Fax).HasMaxLength(300);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(300);

                entity.Property(e => e.HalfHour)
                    .HasColumnName("HALF_HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.HandleTime).HasColumnName("HANDLE_TIME");

                entity.Property(e => e.HoldTime).HasColumnName("HOLD_TIME");

                entity.Property(e => e.Holds).HasColumnName("HOLDS");

                entity.Property(e => e.Hour)
                    .HasColumnName("HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.HourOfDay).HasColumnName("HOUR_OF_DAY");

                entity.Property(e => e.Info1)
                    .HasColumnName("INFO1")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info10)
                    .HasColumnName("INFO10")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info11)
                    .HasColumnName("INFO11")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info12)
                    .HasColumnName("INFO12")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info13)
                    .HasColumnName("INFO13")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info14)
                    .HasColumnName("INFO14")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info15)
                    .HasColumnName("INFO15")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info2)
                    .HasColumnName("INFO2")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info3)
                    .HasColumnName("INFO3")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info4)
                    .HasColumnName("INFO4")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info5)
                    .HasColumnName("INFO5")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info6)
                    .HasColumnName("INFO6")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info7)
                    .HasColumnName("INFO7")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info8)
                    .HasColumnName("INFO8")
                    .HasMaxLength(1000);

                entity.Property(e => e.Info9)
                    .HasColumnName("INFO9")
                    .HasMaxLength(1000);

                entity.Property(e => e.IvrPath).HasColumnName("IVR_PATH");

                entity.Property(e => e.IvrTime).HasColumnName("IVR_TIME");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(300);

                entity.Property(e => e.ListName)
                    .HasColumnName("LIST_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.ListName1)
                    .HasColumnName("ListName")
                    .HasMaxLength(300);

                entity.Property(e => e.LiveConnect).HasColumnName("LIVE_CONNECT");

                entity.Property(e => e.ManualTime).HasColumnName("MANUAL_TIME");

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasMaxLength(1000);

                entity.Property(e => e.NoPartyContact).HasColumnName("NO_PARTY_CONTACT");

                entity.Property(e => e.Notes).HasColumnName("NOTES");

                entity.Property(e => e.Number1)
                    .HasColumnName("number1")
                    .HasMaxLength(300);

                entity.Property(e => e.Number2)
                    .HasColumnName("number2")
                    .HasMaxLength(300);

                entity.Property(e => e.Number3)
                    .HasColumnName("number3")
                    .HasMaxLength(300);

                entity.Property(e => e.NumberOfEmployees)
                    .HasColumnName("Number_of_Employees")
                    .HasMaxLength(300);

                entity.Property(e => e.ParentSessionId)
                    .HasColumnName("PARENT_SESSION_ID")
                    .HasMaxLength(300);

                entity.Property(e => e.ParkTime).HasColumnName("PARK_TIME");

                entity.Property(e => e.Parks).HasColumnName("PARKS");

                entity.Property(e => e.Phone1Desc)
                    .HasColumnName("Phone1_desc")
                    .HasMaxLength(300);

                entity.Property(e => e.Phone2Desc)
                    .HasColumnName("Phone2_desc")
                    .HasMaxLength(300);

                entity.Property(e => e.PitchSection)
                    .HasColumnName("Pitch_Section")
                    .HasMaxLength(300);

                entity.Property(e => e.PreviewInterrupted).HasColumnName("PREVIEW_INTERRUPTED");

                entity.Property(e => e.PreviewInterruptedByCall).HasColumnName("PREVIEW_INTERRUPTED_BY_CALL");

                entity.Property(e => e.PreviewInterruptedBySkillVm)
                    .HasColumnName("PREVIEW_INTERRUPTED_BY_SKILL_VM")
                    .HasMaxLength(300);

                entity.Property(e => e.PreviewTime).HasColumnName("PREVIEW_TIME");

                entity.Property(e => e.Program).HasMaxLength(300);

                entity.Property(e => e.Q1).HasMaxLength(1000);

                entity.Property(e => e.Q10).HasMaxLength(1000);

                entity.Property(e => e.Q11).HasMaxLength(1000);

                entity.Property(e => e.Q12).HasMaxLength(1000);

                entity.Property(e => e.Q13).HasMaxLength(1000);

                entity.Property(e => e.Q14).HasMaxLength(1000);

                entity.Property(e => e.Q15).HasMaxLength(1000);

                entity.Property(e => e.Q2).HasMaxLength(1000);

                entity.Property(e => e.Q3).HasMaxLength(1000);

                entity.Property(e => e.Q4).HasMaxLength(1000);

                entity.Property(e => e.Q5).HasMaxLength(1000);

                entity.Property(e => e.Q6).HasMaxLength(1000);

                entity.Property(e => e.Q7).HasMaxLength(1000);

                entity.Property(e => e.Q8).HasMaxLength(1000);

                entity.Property(e => e.Q9).HasMaxLength(1000);

                entity.Property(e => e.QcsId)
                    .HasColumnName("QCS_ID")
                    .HasMaxLength(300);

                entity.Property(e => e.Quantity).HasMaxLength(300);

                entity.Property(e => e.QuarterHour)
                    .HasColumnName("QUARTER_HOUR")
                    .HasMaxLength(50);

                entity.Property(e => e.QueueCallbackProcessing)
                    .HasColumnName("QUEUE_CALLBACK_PROCESSING")
                    .HasMaxLength(300);

                entity.Property(e => e.QueueCallbackRegistered)
                    .HasColumnName("QUEUE_CALLBACK_REGISTERED")
                    .HasMaxLength(300);

                entity.Property(e => e.QueueCallbackWaitTime)
                    .HasColumnName("QUEUE_CALLBACK_WAIT_TIME")
                    .HasMaxLength(300);

                entity.Property(e => e.QueueWaitTime).HasColumnName("QUEUE_WAIT_TIME");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.ReadOnlySection)
                    .HasColumnName("ReadOnly_Section")
                    .HasMaxLength(300);

                entity.Property(e => e.Recordings)
                    .HasColumnName("RECORDINGS")
                    .HasMaxLength(1000);

                entity.Property(e => e.RingTime).HasColumnName("RING_TIME");

                entity.Property(e => e.ServiceLevel)
                    .HasColumnName("SERVICE_LEVEL")
                    .HasMaxLength(5);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SESSION_ID")
                    .HasMaxLength(1000);

                entity.Property(e => e.ShippingAddress1)
                    .HasColumnName("Shipping_Address1")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingAddress2)
                    .HasColumnName("Shipping_Address2")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("Shipping_City")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingCompany)
                    .HasColumnName("Shipping_Company")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingFirstName)
                    .HasColumnName("Shipping_First_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingLastName)
                    .HasColumnName("Shipping_Last_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingState)
                    .HasColumnName("Shipping_State")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingTitle)
                    .HasColumnName("Shipping_Title")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingZip)
                    .HasColumnName("Shipping_Zip")
                    .HasMaxLength(300);

                entity.Property(e => e.Sic).HasMaxLength(300);

                entity.Property(e => e.Skill)
                    .HasColumnName("SKILL")
                    .HasMaxLength(1000);

                entity.Property(e => e.SpeedOfAnswer).HasColumnName("SPEED_OF_ANSWER");

                entity.Property(e => e.SpokeTo)
                    .HasColumnName("Spoke_To")
                    .HasMaxLength(300);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(1000);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(300);

                entity.Property(e => e.TalkTime).HasColumnName("TALK_TIME");

                entity.Property(e => e.TalkTimeLessHoldAndPark).HasColumnName("TALK_TIME_LESS_HOLD_AND_PARK");

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.TimeInterval)
                    .HasColumnName("TIME_INTERVAL")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeToAbandon)
                    .HasColumnName("TIME_TO_ABANDON")
                    .HasMaxLength(300);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimestampMillisecond)
                    .HasColumnName("TIMESTAMP_MILLISECOND")
                    .HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(300);

                entity.Property(e => e.TotalQueueTime)
                    .HasColumnName("TOTAL_QUEUE_TIME")
                    .HasMaxLength(300);

                entity.Property(e => e.Transfers)
                    .HasColumnName("TRANSFERS")
                    .HasMaxLength(5);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.VideoTime)
                    .HasColumnName("VIDEO_TIME")
                    .HasMaxLength(300);

                entity.Property(e => e.Voicemails).HasColumnName("VOICEMAILS");

                entity.Property(e => e.VoicemailsDeclined)
                    .HasColumnName("VOICEMAILS_DECLINED")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsDeleted)
                    .HasColumnName("VOICEMAILS_DELETED")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsHandleTime).HasColumnName("VOICEMAILS_HANDLE_TIME");

                entity.Property(e => e.VoicemailsHandled)
                    .HasColumnName("VOICEMAILS_HANDLED")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsReturnedCall)
                    .HasColumnName("VOICEMAILS_RETURNED_CALL")
                    .HasMaxLength(5);

                entity.Property(e => e.VoicemailsTransferred)
                    .HasColumnName("VOICEMAILS_TRANSFERRED")
                    .HasMaxLength(5);

                entity.Property(e => e.Year).HasColumnName("YEAR");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(300);

                entity.Property(e => e._3rdPartyTalkTime).HasColumnName("3RD_PARTY_TALK_TIME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
