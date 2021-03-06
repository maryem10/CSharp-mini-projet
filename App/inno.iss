; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "My Program"
#define MyAppVersion "1.5"
#define MyAppPublisher "My Company, Inc."
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "Gestion_Etudiants.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{D7E0523E-57D2-44E7-BC52-A3B9328C0334}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\POSTE\Desktop\App\App
OutputBaseFilename=Setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\POSTE\Desktop\App\Release\Gestion_Etudiants.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\POSTE\Desktop\App\Release\gestion_etudiant.mdf"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\POSTE\Desktop\App\Release\gestion_etudiant_log.ldf"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\POSTE\Desktop\App\Release\Gestion_Etudiants.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\POSTE\Desktop\App\Release\Gestion_Etudiants.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\POSTE\Desktop\App\Release\Gestion_Etudiants.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

