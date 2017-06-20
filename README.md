# diablo3hub
Diablo 3 hub for uwp app

##### 0. 기본 개발 환경
* Windows 10 version 1607 (OS 빌드 14393)
* Windows 10 SDK 14393 installed -  
* Windows 10 SDK 15063 installed - https://developer.microsoft.com/ko-kr/windows/downloads/windows-10-sdk
* Visual Studio 2017
* C# 7.0
* GitHub Source Tool - SourceTree(https://www.sourcetreeapp.com/) 설치하면 GitHub와 연동해서 작업하기가 쉽습니다.
* 프로젝트 Coding Conventions - ReSharper의 기본 코딩 규칙을 사용합니다.
* 프로퍼티와 메소드에 간단하게라도 주석을 꼭 달아 주셔야 합니다.


##### 1. Template 10 - MVVM pattern
* 현재 VS 2017 - Extensions에서는 검색이 않되므로
* https://github.com/Windows-XAML/Template10/issues/1442 주소로 이동해서 Jerry Nixon 아저씨가 처음에 작성한 글의 
* https://1drv.ms/f/s!Aq5BEHo6GlC-t7Nq2MfoysgSaZknJA 원드라이브 링크를 다운로드 받아서 설치합니다.


##### 2. ApiKeys.publishsettings 파일 내용 구성 (아래 각 라인에서 [ ]는 삭제)
* ApiKeys.publishsettings.temp 파일을 이용합니다. 파일명에서 .temp 삭제
* Key=[https://dev.battle.net/ 에서 받은 API Key]
* Secret=[https://dev.battle.net/ 에서 받은 API Secret]
* 해당 파일의 Build Action, Copy to Output Directory 속성 값에 유의합니다. Content / Copy


##### 3. SQLite를 이용해서 BattleTag 목록을 관리
* SQLite for Universal Windows Platform 3.18.0 -> Extensions 수동으로 설치가 필요합니다.
* Nugget Package sqlite-net-pcl 버전으로 사용 -> 자동 설치됩니다.


##### 4. 언어 리소스 관리
* Multilingual App Toolkit 4.0.6799.0 버전 사용 예정 -> 미설치시 오류가 발생할 수 있으니 미리 설치 필요합니다.


##### 5. 작업(To do)
* 작업을 하시려면 https://github.com/kaki104/diablo3hub/projects/1 페이지를 엽니다.
* 등록되어 있는 티켓을 마우스로 드레그 드롭해서 In Progress로 이동을 한 후 진행할 수 있습니다.
* 새로운 작업 생성은 To do에 하시고, In Progress로 이동하신 후 진행할 수 있습니다.
* 화면 작업의 기준은 Guide for Diablo라는 앱의 화면을 기준으로 우선 작업을 합니다.


##### 6. UWP Community Toolkit을 이용해서 화면 디자인 합니다.
* 주소 : https://github.com/Microsoft/UWPCommunityToolkit
* Manage NuGet Package에서 uwp toolkit으로 검색해서 나오는 녀석들을 추가했습니다.
* 이 녀석을 이용해서 어떤 컨트롤이나 서비스를 이용할 수 있는지 살펴 보려면, Store에서 Community Toolkit으로 검색하시면 UWP Community Toolkit Sample app이 나오고, 설치하시면 됩니다.
* 누겟으로 추가를 하고나면, 디자인 타임에 아무것도 나오지 않을 수 있습니다. 비주얼스튜디오를 재시작하면 됩니다.


##### PS. Diablo 3 시즌 10이 진행 중입니다.(26일 시즌 종료 후 4주후에 시즌11시작합니다.)
* 저의 배틀태그는 아시아 - SuperOwl#1417 입니다. 접속하셔서 귓주시면 무료 만렙 버스 운행합니다.
* 접속 시간은 평일 11~12시 정도 입니다.
