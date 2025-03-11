import * as React from 'react';
import Badge, { badgeClasses } from '@mui/material/Badge';
import IconButton, { IconButtonProps } from '@mui/material/IconButton';

interface MenuButtonProps extends IconButtonProps {
  showBadge?: boolean;
}

const MenuButton: React.FC<MenuButtonProps> = ({
                                                 showBadge = false,
                                                 ...props
                                               }) => {
  return (
    <Badge
      color="error"
      variant="dot"
      invisible={!showBadge}
      sx={{ [`& .${badgeClasses.badge}`]: { right: 2, top: 2 } }}
    >
      <IconButton size="small" {...props} />
    </Badge>
  );
};

export default MenuButton;