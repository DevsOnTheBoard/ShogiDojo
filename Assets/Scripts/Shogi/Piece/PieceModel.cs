using UniRx;

public class PieceModel
{
	private ReactiveProperty<PieceType> _pieceType;
	private ReactiveProperty<PiecePosition> _piecePosition;
	private ReactiveProperty<bool> _isShowOutline;
	private ReactiveProperty<int> _pieceNum;

	public IReadOnlyReactiveProperty<PieceType> PieceType => _pieceType;
	public IReadOnlyReactiveProperty<PiecePosition> PiecePosition => _piecePosition;
	public IReadOnlyReactiveProperty<bool> IsShowOutline => _isShowOutline;
	public IReadOnlyReactiveProperty<int> PieceNum => _pieceNum;

	public PieceModel()
	{
		_pieceType = new ReactiveProperty<PieceType>();
		_piecePosition = new ReactiveProperty<PiecePosition>();
		_isShowOutline = new ReactiveProperty<bool>();
		_pieceNum = new ReactiveProperty<int>();
	}

	public void SetPieceType(PieceType pieceType)
	{
		_pieceType.Value = pieceType;
	}
	
	public void SetPiecePosition(PiecePosition piecePosition)
	{
		_piecePosition.Value = piecePosition;
	}
	
	public void SetIsShowOutline(bool isShow)
	{
		_isShowOutline.Value = isShow;
	}
	
	public void SetPieceNum(int pieceNum)
	{
		_pieceNum.Value = pieceNum;
	}
}