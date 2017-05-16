# diablo3hub
diablo3 hub uwp app

1. 기본 개발 환경
* Windows 10 version 1607
* UWP SDK 14393, 15063 installed
* Visual Studio 2017
* C# 7.0
* GitHub Source 관리 - SourceTree(https://www.sourcetreeapp.com/) 설치하면 GitHub와 연동해서 작업하기가 쉽습니다.
* Template 10 - MVVM pattern
. https://github.com/Windows-XAML/Template10/issues/1442 주소로 이동해서 JerryNixon 아저씨가 처음에 작성한 글의 링크를 타고
원드라이브로 넘어가서 다운로드 받아서 설치한다.
. 현재 VS 2017 - Extensions에서는 검색이 않됨
* 프로젝트 Coding Conventions - ReSharper의 기본 코딩 규칙을 사용합니다.
* 프로퍼티와 메소드에 간단하게라도 주석을 꼭 달아 주셔야 합니다.


2. ApiKeys.publishsettings 파일 내용 구성, 아래 문장에서 []는 삭제하고 만들어야함
* ApiKeys.publishsettings.temp 파일을 참고 한다.
* Key=[https://dev.battle.net/에서 받은 API Key]
* Secret=[https://dev.battle.net/에서 받은 API Secret]


3. SQLite를 이용해서 BattleTag 목록을 관리
* SQLite for Universal Windows Platform 3.18.0 -> Extensions 설치 필요
* Nugget Package sqlite-net-pcl 버전으로 사용 -> 자동 설치


4. 언어 리소스 관리
* Multilingual App Toolkit 4.0.6799.0 버전 사용 예정 -> 미설치시 오류가 발생할 수 있으니 미리 설치 필요


5. 작업(To do)
* 작업을 하시려면 https://github.com/kaki104/diablo3hub/projects/1 페이지를 엽니다.
* 등록되어 있는 티켓을 마우스로 드레그 드롭해서 In Progress로 이동을 한 후 진행할 수 있습니다.
* 새로운 작업 생성은 To do에 하시고, In Progress로 이동하신 후 진행할 수 있습니다.
* 화면 작업의 기준은 Guide for Diablo라는 앱의 화면을 기준으로 우선 작업을 합니다.


PS. Diablo 3 시즌 10이 진행 중입니다.
* 저의 배틀테그는 아시아 - SuperOwl#1417 입니다. 접속하셔서 귓주시면 무료 만렙 버스 운행합니다.
* 접속 시간은 평일 10~12시 정도 입니다.
