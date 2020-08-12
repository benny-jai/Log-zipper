namespace Zipper.Enums
{
    public enum EntryEnum
    {
        AssetSubmittedForApproval = 1,
        AddedAssetsWithRespectiveTitles = 2,
        SubmittedForApproval = 3,
        AssetActivated = 4,
        AssetDeactivated = 5,
        LinkReactivated = 6,
        AssetReactivated = 7,
        LinkDeactivated = 8,
        AssetDeactivatedWithTitle = 9,
        ProjectTaskSubmittedForApproval = 10,
        ProjectTaskFinished = 11,
        TaskFinished = 12,
        ProjectTaskApproved = 13,
        TaskApproved = 14,
        ApprovedBy = 15,
        ProjectTaskDeleted = 16,
        TaskDeleted = 17,
        PushFilesToLibrary = 18,
        NewVersionAddedBy = 19,
        NewVersionAddedToTask = 20,
        SaveAsDraft = 21,
        NewVersionApprovalProcessRestart = 22,
        NewVersionApprovalProcessContinue = 23,
        NewVersionOfApprovalProcessRestart = 24,
        NewVersionOfApprovalProcessContinue = 25,
        NewVersionOfProjectTaskAssetAdded = 26,
        NewAssetAddedToProjectTask = 27,
        WithNewVersionAndTitleApprovalProcessRestart = 28,
        WithNewVersionAndTitleApprovalProcessContinue = 29,
        AddedWithNewVersionAndTitle = 30,
        AssetUploaded = 31,
        NewAssetAdded = 32,
        LinkAdded = 33,
        NewLinkAdded = 34,
        ApprovalContinueWithCurrentVersion = 35,
        ApprovalContinueWithCurrentVersionForAsset = 36,
        ApprovalRestart = 37,
        ApprovalContinued = 38,
        WithNewVersionAndFileApprovalProcessRestart = 39,
        WithNewVersionAndFileApprovalProcessContinue = 40,
        AddedWithNewVersionAndFileName = 41,
        AssetApproved = 42,
        ApprovedSubjectToChange = 43,
        RejectedBy = 44,
        AssetApprovedSubjectToChange = 45,
        AssetRejectedBy = 46,
        ProjectTaskApprovedBy = 47,
        ProjectTaskApprovedSubjectToChange = 48,
        ProjectTaskRejectedBy = 49,
        TaskApprovedSubjectToChange = 50,
        TaskRejectedBy = 51,
        SavedBy = 52,
        ProjectStatusUpdated = 53,
        ProjectDeleted = 54,
        ProfilePicChange = 55,
        UpdatesToUserProfile = 56,
        FirstNameChange = 57,
        RoleChanged = 58,
        LastNameChanged = 59,
        DesignationChanged = 60,
        LandlinePhoneUpdated = 61,
        LandlinePhoneDeleted = 62,
        MobilePhoneUpdated = 63,
        MobilePhoneDeleted = 64,
        BranchUpdated = 65,
        BranchDeleted = 66,
        EmployeeIdUpdated = 67,
        EmployeeIdDeleted = 68,
        EmailChanged = 69,
        AttributeAdded = 70,

        /// <summary>
        /// The attribute updated
        /// </summary>
        AttributeUpdated = 71,

        /// <summary>
        /// The not updated
        /// </summary>
        NotUpdated = 72,

        /// <summary>
        /// The manager added
        /// </summary>
        ManagerAdded = 73,

        /// <summary>
        /// The manager deleted
        /// </summary>
        ManagerDeleted = 74,

        /// <summary>
        /// The out of office start date updated
        /// </summary>
        OutOfOfficeStartDateUpdated = 75,

        /// <summary>
        /// The out of office end date updated
        /// </summary>
        OutOfOfficeEndDateUpdated = 76,

        /// <summary>
        /// The out of office start end date updated
        /// </summary>
        OutOfOfficeStartEndDateUpdated = 77,

        /// <summary>
        /// The out of office dates
        /// </summary>
        OutOfOfficeDates = 78,

        /// <summary>
        /// The tasks delegated
        /// </summary>
        TasksDelegated = 79,

        /// <summary>
        /// The task delegated to
        /// </summary>
        TaskDelegatedTo = 80,

        /// <summary>
        /// The user activation date
        /// </summary>
        UserActivationDate = 81,

        /// <summary>
        /// The update status
        /// </summary>
        UpdateStatus = 82,

        /// <summary>
        /// The update asset version title
        /// </summary>
        UpdateAssetVersionTitle = 83,

        /// <summary>
        /// The new asset added to library
        /// </summary>
        NewAssetAddedToLibrary = 84,

        /// <summary>
        /// The new version added to asset
        /// </summary>
        NewVersionAddedToAsset = 85,

        /// <summary>
        /// The asset replaced
        /// </summary>
        AssetReplaced = 86,

        /// <summary>
        /// The metadata changed
        /// </summary>
        MetadataChanged = 87,

        /// <summary>
        /// The metadata notes changed
        /// </summary>
        MetadataNotesChanged = 88,

        /// <summary>
        /// The metadata keywords changed
        /// </summary>
        MetadataKeywordsChanged = 89,

        /// <summary>
        /// The metadata keywords deleted
        /// </summary>
        MetadataKeywordsDeleted = 90,

        /// <summary>
        /// The asset set as vector type
        /// </summary>
        AssetSetAsVectorType = 91,

        /// <summary>
        /// The asset set as non vector type
        /// </summary>
        AssetSetAsNonVectorType = 92,

        /// <summary>
        /// The expiry date updated
        /// </summary>
        ExpiryDateUpdated = 93,

        /// <summary>
        /// The designer updated
        /// </summary>
        DesignerUpdated = 94,

        /// <summary>
        /// The designer company updated
        /// </summary>
        DesignerCompanyUpdated = 95,

        /// <summary>
        /// The license company updated
        /// </summary>
        LicenseCompanyUpdated = 96,

        /// <summary>
        /// The license expiry date updated
        /// </summary>
        LicenseExpiryDateUpdated = 97,

        /// <summary>
        /// The asset approved by
        /// </summary>
        AssetApprovedBy = 98,

        /// <summary>
        /// The asset has been rejected by
        /// </summary>
        AssetHasBeenRejectedBy = 99,

        /// <summary>
        /// The asset resubmitted for approval
        /// </summary>
        AssetResubmittedForApproval = 100,

        /// <summary>
        /// The new project added
        /// </summary>
        NewProjectAdded = 101,

        /// <summary>
        /// The feedback added
        /// </summary>
        FeedbackAdded = 102,

        /// <summary>
        /// The feedback completed
        /// </summary>
        FeedbackCompleted = 103,

        /// <summary>
        /// The feedback reply added
        /// </summary>
        FeedbackReplyAdded = 104,

        /// <summary>
        /// The sub project added
        /// </summary>
        SubProjectAdded = 105,

        /// <summary>
        /// The changes done
        /// </summary>
        ChangesDoneToProject = 106,

        /// <summary>
        /// The project image updated
        /// </summary>
        ProjectImageUpdated = 107,

        /// <summary>
        /// The project archieved
        /// </summary>
        ProjectArchived = 108,

        /// <summary>
        /// The new project section added
        /// </summary>
        NewProjectSectionAdded = 109,

        /// <summary>
        /// The new task added
        /// </summary>
        NewTaskAdded = 110,

        /// <summary>
        /// The new followers added to task
        /// </summary>
        NewFollowersAddedToTask = 111,

        /// <summary>
        /// The comment shared and added
        /// </summary>
        CommentSharedAndAdded = 112,

        /// <summary>
        /// The replied to comment
        /// </summary>
        RepliedToComment = 113,

        /// <summary>
        /// The asset added from project file to project task
        /// </summary>
        AssetAddedFromProjectFileToProjectTask = 114,

        /// <summary>
        /// The user added files
        /// </summary>
        UserAddedFiles = 115,

        /// <summary>
        /// The user added links
        /// </summary>
        UserAddedLinks = 116,

        /// <summary>
        /// The linkdeleted
        /// </summary>
        Linkdeleted = 117,

        /// <summary>
        /// The asset deleted
        /// </summary>
        AssetDeleted = 118,

        /// <summary>
        /// The asset deleted with title
        /// </summary>
        AssetDeletedWithTitle = 119,

        /// <summary>
        /// The task completed
        /// </summary>
        TaskCompleted = 120,

        /// <summary>
        /// The project templates added
        /// </summary>
        ProjectTemplatesAdded = 121,

        /// <summary>
        /// The new user added
        /// </summary>
        NewUserAdded = 122,

        /// <summary>
        /// The password changed
        /// </summary>
        PasswordChanged = 123,

        /// <summary>
        /// The asset shared
        /// </summary>
        AssetShared = 124,

        /// <summary>
        /// The link shared
        /// </summary>
        LinkShared = 125,

        /// <summary>
        /// The asset shared with title
        /// </summary>
        AssetSharedWithTitle = 126,

        /// <summary>
        /// The asset downloaded with title
        /// </summary>
        AssetDownloadedWithTitle = 127,

        /// <summary>
        /// The praiser praised
        /// </summary>
        PraiserPraised = 128,

        /// <summary>
        /// The praiser shared with individuals
        /// </summary>
        PraiserSharedWithIndividuals = 129,

        /// <summary>
        /// The project shared with associated users
        /// </summary>
        ProjectSharedWithAssociatedUsers = 130,

        /// <summary>
        /// The praise shared to groups except users
        /// </summary>
        PraiseSharedToGroupsExceptUsers = 131,

        /// <summary>
        /// The praise shared with project users
        /// </summary>
        PraiseSharedWithProjectUsers = 132,

        /// <summary>
        /// The praise shared with agency users
        /// </summary>
        PraiseSharedWithAgencyUsers = 133,

        /// <summary>
        /// The file details with no caption
        /// </summary>
        FileDetailsWithNoCaption = 134,

        /// <summary>
        /// The file details with caption text
        /// </summary>
        FileDetailsWithCaptionText = 135,

        /// <summary>
        /// The user shared post to individuals
        /// </summary>
        UserSharedPostToIndividuals = 136,

        /// <summary>
        /// The user shared post to groups
        /// </summary>
        UserSharedPostToGroups = 137,

        /// <summary>
        /// The user shared post to groups except users
        /// </summary>
        UserSharedPostToGroupsExceptUsers = 138,

        /// <summary>
        /// The user shared post to projects
        /// </summary>
        UserSharedPostToProjects = 139,

        /// <summary>
        /// The user shared post to projects include agency users
        /// </summary>
        UserSharedPostToProjectsIncludeAgencyUsers = 140,

        /// <summary>
        /// The user shared post to projects except users
        /// </summary>
        UserSharedPostToProjectsExceptUsers = 141,

        /// <summary>
        /// The post files without caption
        /// </summary>
        PostFilesWithoutCaption = 142,

        /// <summary>
        /// The post files with caption
        /// </summary>
        PostFilesWithCaption = 143,

        /// <summary>
        /// The user posted question and answers
        /// </summary>
        UserPostedQuestionAndAnswers = 144,

        /// <summary>
        /// The poll shared with individuals
        /// </summary>
        PollSharedWithIndividuals = 145,

        /// <summary>
        /// The poll shared with groups
        /// </summary>
        PollSharedWithGroups = 146,

        /// <summary>
        /// The poll shared with groups except users
        /// </summary>
        PollSharedWithGroupsExceptUsers = 147,

        /// <summary>
        /// The poll shared with projects
        /// </summary>
        PollSharedWithProjects = 148,

        /// <summary>
        /// The poll shared with agency users
        /// </summary>
        PollSharedWithAgencyUsers = 149,

        /// <summary>
        /// The poll shared with projects except users
        /// </summary>
        PollSharedWithProjectsExceptUsers = 150,

        /// <summary>
        /// The poll shared with no caption files
        /// </summary>
        PollSharedWithNoCaptionFiles = 151,

        /// <summary>
        /// The poll shared with caption files
        /// </summary>
        PollSharedWithCaptionFiles = 152,

        /// <summary>
        /// The asset approved by user
        /// </summary>
        AssetApprovedByUser = 153,

        /// <summary>
        /// The launch project
        /// </summary>
        LaunchProject = 154,

        /// <summary>
        /// The task added under section
        /// </summary>
        TaskAddedUnderSection = 155,

        /// <summary>
        /// The task delegated
        /// </summary>
        TaskDelegated = 156,

        /// <summary>
        /// The metadate title changed
        /// </summary>
        MetadateTitleChanged = 157,

        /// <summary>
        /// The praise shared to projects except users
        /// </summary>
        PraiseSharedToProjectsExceptUsers = 158,

        /// <summary>
        /// The comment added to asset
        /// </summary>
        CommentAddedToAsset = 159,

        /// <summary>
        /// The follower added to task
        /// </summary>
        FollowerAddedToTask = 160,

        /// <summary>
        /// The new project created
        /// </summary>
        NewProjectCreated = 161,

        /// <summary>
        /// The user shared post
        /// </summary>
        UserSharedPost = 162,

        /// <summary>
        /// The changes done in task
        /// </summary>
        ChangesDoneInTask = 163,

        /// <summary>
        /// The follower deleted from task
        /// </summary>
        FollowerDeletedFromTask = 164,

        /// <summary>
        /// The task owner added to task
        /// </summary>
        TaskOwnerAddedToTask = 165,

        /// <summary>
        /// The new approver added totask
        /// </summary>
        NewApproverAddedToTask = 166,

        /// <summary>
        /// The task owner deleted from task
        /// </summary>
        TaskOwnerDeletedFromTask = 167,

        /// <summary>
        /// The approver deleted fromtask
        /// </summary>
        ApproverDeletedFromTask = 168,

        /// <summary>
        /// The project start date updated
        /// </summary>
        ProjectStartDateUpdated = 169,

        /// <summary>
        /// The project end date updated
        /// </summary>
        ProjectEndDateUpdated = 170,

        /// <summary>
        /// The project actual budget updated
        /// </summary>
        ProjectActualBudgetUpdated = 171,

        /// <summary>
        /// The project estimated budget updated
        /// </summary>
        ProjectEstimatedBudgetUpdated = 172,

        /// <summary>
        /// The project name updated
        /// </summary>
        ProjectNameUpdated = 173,

        /// <summary>
        /// The project description updated
        /// </summary>
        ProjectDescriptionUpdated = 174,

        /// <summary>
        /// The project owners added deleted
        /// </summary>
        ProjectOwnersAddedDeleted = 175,

        /// <summary>
        /// The project owners added
        /// </summary>
        ProjectOwnersAdded = 176,

        /// <summary>
        /// The project owners deleted
        /// </summary>
        ProjectOwnersDeleted = 177,

        /// <summary>
        /// The project groups added deleted
        /// </summary>
        ProjectGroupsAddedDeleted = 178,

        /// <summary>
        /// The project group added
        /// </summary>
        ProjectGroupAdded = 179,

        /// <summary>
        /// The project group deleted
        /// </summary>
        ProjectGroupDeleted = 180,

        /// <summary>
        /// The post updated
        /// </summary>
        PostUpdated = 181,

        /// <summary>
        /// The praise message updated
        /// </summary>
        PraiseMessageUpdated = 182,

        /// <summary>
        /// The financial year end month change
        /// </summary>
        FinancialYearEndMonthChange = 183,

        /// <summary>
        /// The budget classification change
        /// </summary>
        BudgetClassificationChange = 184,

        /// <summary>
        /// The budget frequency change
        /// </summary>
        BudgetFrequencyChange = 185,

        /// <summary>
        /// The include tax changed
        /// </summary>
        IncludeTaxChanged = 186,

        /// <summary>
        /// The primary currency changed
        /// </summary>
        PrimaryCurrencyChanged = 187,

        /// <summary>
        /// The secondary currency updated
        /// </summary>
        SecondaryCurrencyUpdated = 188,

        /// <summary>
        /// The secondary currency added
        /// </summary>
        SecondaryCurrencyAdded = 189,

        /// <summary>
        /// The secondary currency removed
        /// </summary>
        SecondaryCurrencyRemoved = 190,

        /// <summary>
        /// The finance setting set up
        /// </summary>
        FinanceSettingSetUp = 191,

        /// <summary>
        /// The new budget for group
        /// </summary>
        NewBudgetForGroup = 192,

        /// <summary>
        /// The new budget for division
        /// </summary>
        NewBudgetForDivision = 193,

        /// <summary>
        /// The new budget created for
        /// </summary>
        NewBudgetCreatedFor = 194,

        /// <summary>
        /// The budget limit updated
        /// </summary>
        BudgetLimitUpdated = 195,

        /// <summary>
        /// The budget updated
        /// </summary>
        BudgetUpdated = 196,

        /// <summary>
        /// The budget for updated
        /// </summary>
        BudgetForUpdated = 197,

        /// <summary>
        /// The budget name updated
        /// </summary>
        BudgetNameUpdated = 198,

        /// <summary>
        /// The budget description updated
        /// </summary>
        BudgetDescriptionUpdated = 199,

        /// <summary>
        /// The budget currency updated
        /// </summary>
        BudgetCurrencyUpdated = 200,

        /// <summary>
        /// The budget amount updated
        /// </summary>
        BudgetAmountUpdated = 201,

        /// <summary>
        /// The budget financial year updated
        /// </summary>
        BudgetFinancialYearUpdated = 202,

        /// <summary>
        /// The budget financial period updated
        /// </summary>
        BudgetFinancialPeriodUpdated = 203,

        /// <summary>
        /// The budget deleted
        /// </summary>
        BudgetDeleted = 204,

        /// <summary>
        /// The added single asset with respective title
        /// </summary>
        AddedSingleAssetWithRespectiveTitle = 205,

        /// <summary>
        /// The push single file to library
        /// </summary>
        PushSingleFileToLibrary = 206,

        /// <summary>
        /// The alias updated
        /// </summary>
        AliasUpdated = 207,

        /// <summary>
        /// The default account updated
        /// </summary>
        DefaultAccountUpdated = 208,

        /// <summary>
        /// A user was invited to a task
        /// </summary>
        UserInvitedToTask = 209,

        /// <summary>
        /// A budget was submitted for review
        /// </summary>
        BudgetSubmitForReview = 210,

        /// <summary>
        /// A budget was approved
        /// </summary>
        BudgetApproved = 211,

        /// <summary>
        /// A budget was approved with changes
        /// </summary>
        BudgetApprovedWithChanges = 212,

        /// <summary>
        /// A budget was rejected
        /// </summary>
        BudgetRejected = 213,

        /// <summary>
        /// A new version of a budget was created.
        /// </summary>
        BudgetVersionCreated = 214,

        /// <summary>
        /// A budget was revised.
        /// </summary>
        BudgetRevised = 215,

        /// <summary>
        /// A budget was completed.
        /// </summary>
        BudgetCompleted = 216,

        /// <summary>
        ///  Feedback was added to budget master category
        /// </summary>
        BudgetMasterCategoryFeedbackAdded = 217,

        /// <summary>
        /// Feedback was added to manual top-level category
        /// </summary>
        BudgetCategoryFeedbackAdded = 218,

        /// <summary>
        /// Feedback was added to budget subcategory
        /// </summary>
        BudgetSubcategoryFeedbackAdded = 219,

        /// <summary>
        /// General feedback was added (applies all categories)
        /// </summary>
        BudgetGeneralFeedbackAdded = 220,

        /// <summary>
        /// A reply was made to feedback on a master category
        /// </summary>
        BudgetMasterCategoryFeedbackReply = 221,

        /// <summary>
        /// A reply was made to feedback on a top-level category
        /// </summary>
        BudgetCategoryFeedbackReply = 222,

        /// <summary>
        /// A reply was made to feedback on a subcategory
        /// </summary>
        BudgetSubcategoryFeedbackReply = 223,

        /// <summary>
        /// A reply was made to general feedback
        /// </summary>
        BudgetGeneralFeedbackReply = 224,

        /// <summary>
        /// Feedback on a master category was marked as complete
        /// </summary>
        BudgetMasterCategoryFeedbackClosed = 225,

        /// <summary>
        /// Feedback on a category was marked as complete
        /// </summary>
        BudgetCategoryFeedbackClosed = 226,

        /// <summary>
        /// Feedback on a subcategory has been closed
        /// </summary>
        BudgetSubcategoryFeedbackClosed = 227,

        /// <summary>
        /// General feedback has been closed
        /// </summary>
        BudgetGeneralFeedbackClosed = 228,

        /// <summary>
        /// A budget owner has been added
        /// </summary>
        BudgetOwnerAdded = 229,

        /// <summary>
        /// A budget contributor has been added
        /// </summary>
        BudgetContributorAdded = 230,

        /// <summary>
        /// A budget follower has been added
        /// </summary>
        BudgetFollowerAdded = 231,

        /// <summary>
        /// A budget approver has been added
        /// </summary>
        BudgetApproverAdded = 232,

        /// <summary>
        /// A budget owner has been removed
        /// </summary>
        BudgetOwnerRemoved = 233,

        /// <summary>
        /// A budget contributor has been removed
        /// </summary>
        BudgetContributorRemoved = 234,

        /// <summary>
        /// A budget follower has been removed
        /// </summary>
        BudgetFollowerRemoved = 235,

        /// <summary>
        /// A budget approver has been removed
        /// </summary>
        BudgetApproverRemoved = 236,

        /// <summary>
        /// A budget has been created
        /// </summary>
        BudgetCreated = 237,

        /// <summary>
        /// User activity log for project delegation
        /// </summary>
        ProjectDelegatedByUser = 238,

        /// <summary>
        /// A project has been delegated
        /// </summary>
        ProjectDelegated = 239,

        /// <summary>
        /// Expense Item has been deleted.
        /// </summary>
        ExpenseDeleted = 240,

        /// <summary>
        /// Expense Item has been moved.
        /// </summary>
        ExpenseUpdated = 241,

        /// <summary>
        /// The user was de-activated.
        /// </summary>
        UserDeactivated = 242,

        /// <summary>
        /// The user de-activated another user.
        /// </summary>
        UserDeactivatedOtherUser = 243,

        /// <summary>
        /// The user was re-activated by another user.
        /// </summary>
        UserReactivated = 244,

        /// <summary>
        /// The user re-activated another user.
        /// </summary>
        UserReactivatedOtherUser = 245,

        /// <summary>
        /// The task was re-opened
        /// </summary>
        TaskReopened = 246,

        /// <summary>
        /// The project task was re-opened
        /// </summary>
        ProjectTaskReopened = 247,

        /// <summary>
        /// A general task was created.
        /// </summary>
        GeneralTaskCreated = 248,

        /// <summary>
        /// An assignee has been added to a general task.
        /// </summary>
        GeneralTaskAssigneeAdded = 249,

        /// <summary>
        /// A requestor has been added to a general task.
        /// </summary>
        GeneralTaskRequestorAdded = 250,

        /// <summary>
        /// A follower has been added to a general task.
        /// </summary>
        GeneralTaskFollowerAdded = 251,

        /// <summary>
        /// A follower has been removed from a general task.
        /// </summary>
        GeneralTaskFollowerRemoved = 252,

        /// <summary>
        /// A general task has been completed.
        /// </summary>
        GeneralTaskCompleted = 253,

        /// <summary>
        /// The status of a general task has been updated.
        /// </summary>
        GeneralTaskStatusUpdated = 254,

        /// <summary>
        /// A general task has been renamed.
        /// </summary>
        GeneralTaskRenamed = 255,

        /// <summary>
        /// The description of a general task has been updated.
        /// </summary>
        GeneralTaskDescriptionUpdated = 256,

        /// <summary>
        /// The due date of a general task has been updated.
        /// </summary>
        GeneralTaskDueDateUpdated = 257,

        /// <summary>
        /// The due date of a general task has been cleared.
        /// </summary>
        GeneralTaskDueDateCleared = 258,

        /// <summary>
        /// A supporting file has been added to a general task.
        /// </summary>
        GeneralTaskSupportingFileAdded = 259,

        /// <summary>
        /// A supporting file has been deleted from a general task.
        /// </summary>
        GeneralTaskSupportingFileDeleted = 260,

        /// <summary>
        /// An asset has been added to a general task.
        /// </summary>
        GeneralTaskAssetAdded = 261,

        /// <summary>
        /// An asset has been deleted from a general task.
        /// </summary>
        GeneralTaskAssetDeleted = 262,

        /// <summary>
        /// An asset has been approved in a general task.
        /// </summary>
        GeneralTaskAssetApproved = 263,

        /// <summary>
        /// An asset has had its approval revoked in a general task.
        /// </summary>
        GeneralTaskAssetApprovalRevoked = 264,

        /// <summary>
        /// An approver has been added to an asset in a general task (without approval level details).
        /// </summary>
        GeneralTaskAssetApproverAdded = 265,

        /// <summary>
        /// An approver has been removed from an asset in a general task (without approval level details).
        /// </summary>
        GeneralTaskAssetApproverRemoved = 266,

        /// <summary>
        /// A new version of a general task asset has been uploaded.
        /// </summary>
        GeneralTaskAssetVersionAdded = 267,

        /// <summary>
        /// A general task asset has been renamed.
        /// </summary>
        GeneralTaskAssetRenamed = 268,

        /// <summary>
        /// A general task has been assigned to anyone.
        /// </summary>
        GeneralTaskAssignedToAnyone = 269,

        /// <summary>
        /// The LinkUrl of a general task asset has been edited.
        /// </summary>
        GeneralTaskLinkUrlUpdated = 270,

        /// <summary>
        /// New permissions granted to the user.
        /// </summary>
        PermissionGrantedToUser = 271,

        /// <summary>
        /// Permissions revoked from the user.
        /// </summary>
        PermissionRevokedFromUser = 272,

        /// <summary>
        /// Impersonating a customer user.
        /// </summary>
        ImpersonateCustomerUser = 273,

        /// <summary>
        /// Followers added and deleted from a project.
        /// </summary>
        ProjectFollowersAddedDeleted = 274,

        /// <summary>
        /// Followers added to a project.
        /// </summary>
        ProjectFollowersAdded = 275,

        /// <summary>
        /// Followers deleted from a project.
        /// </summary>
        ProjectFollowersDeleted = 276,

        /// <summary>
        /// An approval workflow has been created.
        /// </summary>
        ApprovalWorkflowCreated = 277,

        /// <summary>
        /// An approval workflow has been renamed.
        /// </summary>
        ApprovalWorkflowRenamed = 278,

        /// <summary>
        /// A user has been added to an approval workflow.
        /// </summary>
        ApprovalWorkflowUserAdded = 279,

        /// <summary>
        /// A user has been removed from an approval workflow.
        /// </summary>
        ApprovalWorkflowUserRemoved = 280,

        /// <summary>
        /// A role has been added to an approval workflow.
        /// </summary>
        ApprovalWorkflowRoleAdded = 281,

        /// <summary>
        /// A role has been removed from an approval workflow.
        /// </summary>
        ApprovalWorkflowRoleRemoved = 282,

        /// <summary>
        /// An approver has been added to an asset in a general / non-project task (including approval level details).
        /// </summary>
        GeneralTaskAssetApproverAdded_IncludesApprovalLevelDetails = 283,

        /// <summary>
        /// An approver has been removed from an asset in a general / non-project task (without approval level details).
        /// </summary>
        GeneralTaskAssetApproverRemoved_IncludesApprovalLevelDetails = 284,

        /// <summary>
        /// A new SSO user has been provisioned from Okta.
        /// </summary>
        NewSSOUserProvisioned = 285,

        /// <summary>
        /// An SSO user has been de-activated.
        /// </summary>
        SSOUserDeactivated = 286,

        /// <summary>
        /// An SSO user has been re-activated.
        /// </summary>
        SSOUserReactivated = 287,

        /// <summary>
        /// The approval workflow for a general task has been set when previously no approval workflow was set.
        /// </summary>
        GeneralTaskAssetApprovalWorkflowSet = 288,

        /// <summary>
        /// The approval workflow for a general task has been updated.
        /// </summary>
        GeneralTaskAssetApprovalWorkflowUpdated = 289,

        /// <summary>
        /// The approval workflow for a general task has been cleared.
        /// </summary>
        GeneralTaskAssetApprovalWorkflowCleared = 290,

        /// <summary>
        /// Copy a job.
        /// </summary>
        CopyJob = 291,

        /// <summary>
        /// Changes have been made to a job project.
        /// </summary>
        ChangesDoneToJobProject = 292,

        /// <summary>
        /// An owner/s has been added to a job project.
        /// </summary>
        JobProjectOwnerAdded = 293,

        // <summary>
        /// An owner/s has been removed from a job project.
        /// </summary>
        JobProjectOwnerRemoved = 294,

        /// <summary>
        /// A job project has been renamed.
        /// </summary>
        JobProjectRenamed = 295,

        /// <summary>
        /// The description of a job project has been updated.
        /// </summary>
        JobProjectDescriptionUpdated = 296,

        /// <summary>
        /// The start / live date of a job project has been updated.
        /// </summary>
        JobProjectStartDateUpdated = 297,

        /// <summary>
        /// The end date of a job project has been updated.
        /// </summary>
        JobProjectEndDateUpdated = 298,

        /// <summary>
        /// The actual budget of a job project has been updated.
        /// </summary>
        JobProjectActualBudgetUpdated = 299,

        /// <summary>
        /// The estimated budget of a job project has been updated.
        /// </summary>
        JobProjectEstimatedBudgetUpdated = 300,

        /// <summary>
        /// A group/s has been added to a job project.
        /// </summary>
        JobProjectGroupAdded = 301,

        /// <summary>
        /// A group/s has been removed from a job project.
        /// </summary>
        JobProjectGroupRemoved = 302,

        /// <summary>
        /// The status of a job project has been updated.
        /// </summary>
        JobProjectStatusUpdated = 303,

        /// <summary>
        /// The value of an attribute in a job project has been set.
        /// </summary>
        JobProjectAttributeValueSet = 304,

        /// <summary>
        /// The value of an attribute in a job project has been updated.
        /// </summary>
        JobProjectAttributeValueUpdated = 305,

        /// <summary>
        /// The value of an attribute in a job project has been cleared.
        /// </summary>
        JobProjectAttributeValueCleared = 306,

        /// <summary>
        /// The brief' text answer in a job has been updated.
        /// </summary>
        GeneralTaskBriefTextAnswerUpdated = 311,

        /// <summary>
        /// The brief' date answer in a job has been updated.
        /// </summary>
        GeneralTaskBriefDateAnswerUpdated = 312,

        /// <summary>
        /// The project prefix id updated
        /// </summary>
        ProjectPrefixIdUpdated = 313
    }
}
