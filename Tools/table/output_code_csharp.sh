WORKSPACE=$(cd `dirname $0`; pwd)
SOURCETABLEDIR=$WORKSPACE/../../Tables/Sources/
PROJECTTABLEDIR=$WORKSPACE/../../UnityProject/ClearStar/Assets/Scripts/Game/Tables/

cd $WORKSPACE
./outputcode -i $SOURCETABLEDIR -o $PROJECTTABLEDIR