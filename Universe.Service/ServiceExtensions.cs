﻿namespace Universe.Service
{
    using Core;
    using DataAccess;
    using FluentValidation;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection Service)
        {
            Service.AddDbContext<DbContext>();
            Service.AddDbContext<UniverseContext>();

            Service.AddScoped<IAbility, AbilityRepositoryEF>();
            Service.AddScoped<IAnnounce, AnnounceRepositoryEF>();
            Service.AddScoped<IAnnounceDetail, AnnounceDetailRepositoryEF>();
            Service.AddScoped<IAnnounceLog, AnnounceLogRepositoryEF>();
            Service.AddScoped<ICertificate, CertificateRepositoryEF>();
            Service.AddScoped<ICollege, CollegeRepositoryEF>();
            Service.AddScoped<ICompanyAbout, CompanyAboutRepositoryEF>();
            Service.AddScoped<ICompanyDetail, CompanyDetailRepositoryEF>();
            Service.AddScoped<ICompanyFollower, CompanyFollowerRepositoryEF>();
            Service.AddScoped<ICompany, CompanyRepositoryEF>();
            Service.AddScoped<ICompanySettings, CompanySettingsRepositoryEF>();
            Service.AddScoped<ICountry, CountryRepositoryEF>();
            Service.AddScoped<IEmoji, EmojiRepositoryEF>();
            Service.AddScoped<IJobPostingApply, JobPostingApplyRepositoryEF>();
            Service.AddScoped<IJobPostingDetail, JobPostingDetailRepositoryEF>();
            Service.AddScoped<IJobPosting, JobPostingRepositoryEF>();
            Service.AddScoped<ILanguage, LanguageRepositoryEF>();
            Service.AddScoped<IManagement, ManagementRepositoryEF>();
            Service.AddScoped<IManagementDetail, ManagementDetailRepositoryEF>();
            Service.AddScoped<IManagementContact, ManagementContactRepositoryEF>();
            Service.AddScoped<IManagementEmail, ManagementEmailRepositoryEF>();
            Service.AddScoped<IMessageBox, MessageBoxRepositoryEF>();
            Service.AddScoped<INetworkAction, NetworkActionRepositoryEF>();
            Service.AddScoped<INetworkComment, NetworkCommentRepositoryEF>();
            Service.AddScoped<INetworkDetail, NetworkDetailRepositoryEF>();
            Service.AddScoped<INetwork, NetworkRepositoryEF>();
            Service.AddScoped<IOccupation, OccupationRepositoryEF>();
            Service.AddScoped<IPosition, PositionRepositoryEF>();
            Service.AddScoped<IRegion, RegionRepositoryEF>();
            Service.AddScoped<ISurvey, SurveyRepositoryEF>();
            Service.AddScoped<ISurveyDetail, SurveyDetailRepositoryEF>();
            Service.AddScoped<ISurveyLog, SurveyLogRepositoryEF>();
            Service.AddScoped<ISurveyHistory, SurveyHistoryRepositoryEF>();
            Service.AddScoped<IUserAbility, UserAbilityRepositoryEF>();
            Service.AddScoped<IUserAbout, UserAboutRepositoryEF>();
            Service.AddScoped<IUserCertificate, UserCertificateRepositoryEF>();
            Service.AddScoped<IUserCountry, UserCountryRepositoryEF>();
            Service.AddScoped<IUserDetail, UserDetailRepositoryEF>();
            Service.AddScoped<IUserEducation, UserEducationRepositoryEF>();
            Service.AddScoped<IUserExperience, UserExperienceRepositoryEF>();
            Service.AddScoped<IUserFollower, UserFollowerRepositoryEF>();
            Service.AddScoped<IUserLanguage, UserLanguageRepositoryEF>();
            Service.AddScoped<IUserNetwork, UserNetworkRepositoryEF>();
            Service.AddScoped<IUserProject, UserProjectRepositoryEF>();
            Service.AddScoped<IUserPublish, UserPublishRepositoryEF>();
            Service.AddScoped<IUserReferance, UserReferanceRepositoryEF>();
            Service.AddScoped<IUser, UserRepositoryEF>();
            Service.AddScoped<IUserSettings, UserSettingsRepositoryEF>();
            Service.AddScoped<IUserType, UserTypeRepositoryEF>();
            Service.AddScoped<IUserVideo, UserVideoRepositoryEF>();
            Service.AddScoped<IUnitOfWork, UnitOfWork>();

            Service.AddScoped<IValidator<Ability>, AbilityValidator>();
            Service.AddScoped<IValidator<AnnounceDetail>, AnnounceDetailValidator>();
            Service.AddScoped<IValidator<AnnounceLog>, AnnounceLogValidator>();
            Service.AddScoped<IValidator<Announce>, AnnounceValidator>();
            Service.AddScoped<IValidator<Certificate>, CertificateValidator>();
            Service.AddScoped<IValidator<College>, CollegeValidator>();
            Service.AddScoped<IValidator<CompanyAbout>, CompanyAboutValidator>();
            Service.AddScoped<IValidator<CompanyDetail>, CompanyDetailValidator>();
            Service.AddScoped<IValidator<CompanyFollower>, CompanyFollowerValidator>();
            Service.AddScoped<IValidator<Company>, CompanyLoginValidator>();
            Service.AddScoped<IValidator<CompanySettings>, CompanySettingsValidator>();
            Service.AddScoped<IValidator<Country>, CountryValidator>();
            Service.AddScoped<IValidator<Emoji>, EmojiValidator>();
            Service.AddScoped<IValidator<JobPostingApply>, JobPostingApplyValidator>();
            Service.AddScoped<IValidator<JobPostingDetail>, JobPostingDetailValidator>();
            Service.AddScoped<IValidator<JobPosting>, JobPostingValidator>();
            Service.AddScoped<IValidator<Language>, LanguageValidator>();
            Service.AddScoped<IValidator<ManagementContact>, ManagementContactValidator>();
            Service.AddScoped<IValidator<ManagementDetail>, ManagementDetailValidator>();
            Service.AddScoped<IValidator<ManagementEmail>, ManagementEmailValidator>();
            Service.AddScoped<IValidator<Management>, ManagementValidator>();
            Service.AddScoped<IValidator<MessageBox>, MessageBoxValidator>();
            Service.AddScoped<IValidator<NetworkAction>, NetworkActionValidator>();
            Service.AddScoped<IValidator<NetworkComment>, NetworkCommentValidator>();
            Service.AddScoped<IValidator<NetworkDetail>, NetworkDetailValidator>();
            Service.AddScoped<IValidator<Network>, NetworkValidator>();
            Service.AddScoped<IValidator<Occupation>, OccupationValidator>();
            Service.AddScoped<IValidator<Position>, PositionValidator>();
            Service.AddScoped<IValidator<Region>, RegionValidator>();
            Service.AddScoped<IValidator<SurveyHistory>, SurveyHistoryValidator>();
            Service.AddScoped<IValidator<SurveyDetail>, SurveyDetailValidator>();
            Service.AddScoped<IValidator<SurveyLog>, SurveyLogValidator>();
            Service.AddScoped<IValidator<Survey>, SurveyValidator>();
            Service.AddScoped<IValidator<UserAbility>, UserAbilityValidator>();
            Service.AddScoped<IValidator<UserAbout>, UserAboutValidator>();
            Service.AddScoped<IValidator<UserCertificate>, UserCertificateValidator>();
            Service.AddScoped<IValidator<UserCountry>, UserCountryValidator>();
            Service.AddScoped<IValidator<UserDetail>, UserDetailValidator>();
            Service.AddScoped<IValidator<UserEducation>, UserEducationValidator>();
            Service.AddScoped<IValidator<UserExperience>, UserExperienceValidator>();
            Service.AddScoped<IValidator<UserFollower>, UserFollowerValidator>();
            Service.AddScoped<IValidator<UserLanguage>, UserLanguageValidator>();
            Service.AddScoped<IValidator<User>, UserLoginValidator>();
            Service.AddScoped<IValidator<UserNetwork>, UserNetworkValidator>();
            Service.AddScoped<IValidator<UserProject>, UserProjectValidator>();
            Service.AddScoped<IValidator<UserPublish>, UserPublishValidator>();
            Service.AddScoped<IValidator<UserReferance>, UserReferanceValidator>();
            Service.AddScoped<IValidator<UserSettings>, UserSettingsValidator>();
            Service.AddScoped<IValidator<UserType>, UserTypeValidator>();
            Service.AddScoped<IValidator<User>, UserValidator>();
            Service.AddScoped<IValidator<UserVideo>, UserVideoValidator>();

            Service.AddScoped<IAbilityService, AbilityManager>();
            Service.AddScoped<IAnnounceService, AnnounceManager>();
            Service.AddScoped<IAnnounceDetailService, AnnounceDetailManager>();
            Service.AddScoped<IAnnounceLogService, AnnounceLogManager>();
            Service.AddScoped<ICertificateService, CertificateManager>();
            Service.AddScoped<ICollegeService, CollegeManager>();
            Service.AddScoped<ICompanyAboutService, CompanyAboutManager>();
            Service.AddScoped<ICompanyDetailService, CompanyDetailManager>();
            Service.AddScoped<ICompanyFollowerService, CompanyFollowerManager>();
            Service.AddScoped<ICompanyService, CompanyManager>();
            Service.AddScoped<ICompanySettingsService, CompanySettingsManager>();
            Service.AddScoped<ICountryService, CountryManager>();
            Service.AddScoped<IEmojiService, EmojiManager>();
            Service.AddScoped<IJobPostingApplyService, JobPostingApplyManager>();
            Service.AddScoped<IJobPostingDetailService, JobPostingDetailManager>();
            Service.AddScoped<IJobPostingService, JobPostingManager>();
            Service.AddScoped<ILanguageService, LanguageManager>();
            Service.AddScoped<IManagementContactService, ManagementContactManager>();
            Service.AddScoped<IManagementDetailService, ManagementDetailManager>();
            Service.AddScoped<IManagementEmailService, ManagementEmailManager>();
            Service.AddScoped<IManagementService, ManagementManager>();
            Service.AddScoped<IMessageBoxService, MessageBoxManager>();
            Service.AddScoped<INetworkActionService, NetworkActionManager>();
            Service.AddScoped<INetworkCommentService, NetworkCommentManager>();
            Service.AddScoped<INetworkDetailService, NetworkDetailManager>();
            Service.AddScoped<INetworkService, NetworkManager>();
            Service.AddScoped<IOccupationService, OccupationManager>();
            Service.AddScoped<IPositionService, PositionManager>();
            Service.AddScoped<IRegionService, RegionManager>();
            Service.AddScoped<ISurveyDetailService, SurveyDetailManager>();
            Service.AddScoped<ISurveyHistoryService, SurveyHistoryManager>();
            Service.AddScoped<ISurveyLogService, SurveyLogManager>();
            Service.AddScoped<ISurveyService, SurveyManager>();
            Service.AddScoped<IUserAbilityService, UserAbilityManager>();
            Service.AddScoped<IUserAboutService, UserAboutManager>();
            Service.AddScoped<IUserCertificateService, UserCertificateManager>();
            Service.AddScoped<IUserCountryService, UserCountryManager>();
            Service.AddScoped<IUserDetailService, UserDetailManager>();
            Service.AddScoped<IUserEducationService, UserEducationManager>();
            Service.AddScoped<IUserExperienceService, UserExperienceManager>();
            Service.AddScoped<IUserFollowerService, UserFollowerManager>();
            Service.AddScoped<IUserLanguageService, UserLanguageManager>();
            Service.AddScoped<IUserService, UserManager>();
            Service.AddScoped<IUserNetworkService, UserNetworkManager>();
            Service.AddScoped<IUserProjectService, UserProjectManager>();
            Service.AddScoped<IUserPublishService, UserPublishManager>();
            Service.AddScoped<IUserReferanceService, UserReferanceManager>();
            Service.AddScoped<IUserSettingsService, UserSettingsManager>();
            Service.AddScoped<IUserTypeService, UserTypeManager>();
            Service.AddScoped<IUserVideoService, UserVideoManager>();

            return Service;
        }
    }
}