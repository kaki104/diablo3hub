# diablo3hub
diablo3 hub uwp app

1. 기본 개발 환경
Windows 10 version 1607
UWP SDK 14393, 15063 installed
Visual Studio 2017

기본 템플릿 : Template 10
* https://github.com/Windows-XAML/Template10/issues/1442 주소로 이동해서 JerryNixon 아저씨가 처음에 작성한 글의 링크를 타고
원드라이브로 넘어가서 다운로드 받아서 설치한다.
* 현재 VS 2017 - Extensions에서는 검색이 않됨


2. ApiKeys.publishsettings 파일 내용 구성, 아래 문장에서 []는 삭제하고 만들어야함
Key=[https://dev.battle.net/에서 받은 API Key]
Secret=[https://dev.battle.net/에서 받은 API Secret]


3. SQLite를 이용해서 BattleTag 목록을 관리
* SQLite for Universal Windows Platform 3.18.0 -> Extensions 설치 필요
* Nugget Package sqlite-net-pcl 버전으로 사용 -> 자동 설치


4. 언어 리소스 관리
* Multilingual App Toolkit 4.0.6799.0 버전 사용 예정 -> 미설치시 오류가 발생할 수 있으니 미리 설치 필요
