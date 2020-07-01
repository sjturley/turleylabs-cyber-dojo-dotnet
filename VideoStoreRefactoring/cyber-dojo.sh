
trap tidy_up EXIT
function tidy_up()
{
  # cyber-dojo returns text files under /sandbox that are
  # created/deleted/changed. In here you can remove any
  # such files you don't want returned to the browser.
  [ ! -f TestResult.xml ] || rm TestResult.xml
}

NUNIT_PATH=/nunit/lib/net45
export MONO_PATH=${NUNIT_PATH}:/approvalutils/lib/net461:/approvals/lib/net461:/emptyfiles/net461/

mcs -t:library \
  -r:${NUNIT_PATH}/nunit.framework.dll,/emptyfiles/net461/EmptyFiles.dll,/approvalutils/lib/net461/ApprovalUtilities.dll,/approvals/lib/net461/ApprovalTests.dll \
  -out:RunTests.dll *.cs

if [ $? -eq 0 ]; then
  NUNIT_RUNNERS_PATH=/nunit/tools
  mono ${NUNIT_RUNNERS_PATH}/nunit3-console.exe --noheader ./RunTests.dll
fi

