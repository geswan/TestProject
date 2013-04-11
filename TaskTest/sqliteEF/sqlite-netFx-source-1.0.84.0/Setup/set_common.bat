@ECHO OFF

::
:: set_common.bat --
::
:: Written by Joe Mistachkin.
:: Released to the public domain, use at your own risk!
::

IF NOT DEFINED APPID (
  SET APPID={{02E43EC2-6B1C-45B5-9E48-941C3E1B204A}
)

IF NOT DEFINED URL (
  SET URL=http://system.data.sqlite.org/
)

IF NOT DEFINED PUBLICKEY (
  SET PUBLICKEY=db937bc2d44ff139
)

IF NOT DEFINED BUILD_CONFIGURATIONS (
  SET BUILD_CONFIGURATIONS=Debug DebugNativeOnly Release ReleaseNativeOnly
)

IF NOT DEFINED TEST_CONFIGURATIONS (
  SET TEST_CONFIGURATIONS=Debug Release
)

IF NOT DEFINED BAKE_CONFIGURATIONS (
  SET BAKE_CONFIGURATIONS=Release ReleaseNativeOnly
)

IF NOT DEFINED RELEASE_CONFIGURATIONS (
  SET RELEASE_CONFIGURATIONS=Release ReleaseNativeOnly
)

IF NOT DEFINED PLATFORMS (
  SET PLATFORMS=Win32 x64
)

IF NOT DEFINED PROCESSORS (
  SET PROCESSORS=x86 x64
)

IF NOT DEFINED FRAMEWORK2005 (
  SET FRAMEWORK2005=netFx20
)

IF NOT DEFINED FRAMEWORK2008 (
  SET FRAMEWORK2008=netFx35
)

IF NOT DEFINED FRAMEWORK2010 (
  SET FRAMEWORK2010=netFx40
)

IF NOT DEFINED FRAMEWORK2012 (
  SET FRAMEWORK2012=netFx45
)

IF DEFINED YEARS GOTO end_of_file

IF DEFINED VS2005SP (
  SET YEARS=%YEARS% 2005
)

IF DEFINED VS2008SP (
  SET YEARS=%YEARS% 2008
)

IF DEFINED VS2010SP (
  SET YEARS=%YEARS% 2010
)

IF DEFINED VS2012SP (
  SET YEARS=%YEARS% 2012
)

:end_of_file
