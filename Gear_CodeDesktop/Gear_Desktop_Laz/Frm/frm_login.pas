unit Frm_Login;

{$mode objfpc}{$H+}

interface

uses
  Classes
  ,SysUtils
  ,Forms
  ,Controls
  ,Graphics
  ,Dialogs, Menus;

type

  { TFrmLogin }

  TFrmLogin = class(TForm)
    procedure FormCreate(Sender: TObject);
  private

  public

  end;

var
  FrmLogin: TFrmLogin;

implementation

{$R *.lfm}

{ TFrmLogin }

procedure TFrmLogin.FormCreate(Sender: TObject);
begin
  Application.MessageBox('TESTE','TESTE',mrOK);
end;

end.

